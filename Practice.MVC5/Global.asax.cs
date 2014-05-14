using Practice.MVC5.DI.SM;
using Practice.MVC5.DI.SM.Conventions;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Practice.MVC5.DI.SM.Registries;

namespace Practice.MVC5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Nested Container : Transinet objects are singleton, Dispose objects recursively : when we dispose nested container all the transient objects are disposed
        public IContainer Container
        {
            get
            {
                return (IContainer)HttpContext.Current.Items["_container"];
            }
            set
            {
                HttpContext.Current.Items["_container"] = value;
            }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Set StrucuteMapDependency Resolver to use current Nested Container
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(() => Container ?? ObjectFactory.Container.GetNestedContainer()));

            ObjectFactory.Configure(cfg =>
            {
                cfg.AddRegistry(new StructureMapStandardRegistry());
                cfg.AddRegistry(new StructureMapControllerRegistry());
                cfg.AddRegistry(new StructureMapActionFilterRegistry(() => Container ?? ObjectFactory.Container.GetNestedContainer()));
                cfg.AddRegistry(new StructureMapMvcRegistry());
                cfg.AddRegistry(new StructureMapTaskRegistry());
            });

        }

        public void Application_BeginRequest()
        {
            //Set Nested Container for the current Web Request
            Container = ObjectFactory.Container.GetNestedContainer();
        }

        public void Application_EndRequest()
        {
            //Dispose the nested conainer for the end of the current web request
            Container.Dispose();
            Container = null;
        }
    }
}
