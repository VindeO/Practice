﻿using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Practice.MVC5.DI.SM.Registries
{
    public class StructureMapMvcRegistry:Registry
    {
        public StructureMapMvcRegistry()
        {
            For<BundleCollection>().Use(BundleTable.Bundles);
            For<RouteCollection>().Use(RouteTable.Routes);
            For<IIdentity>().Use(()=>HttpContext.Current.User.Identity);
            For<HttpSessionStateBase>().Use(() => new HttpSessionStateWrapper(HttpContext.Current.Session));
            For<HttpContextBase>().Use(() => new HttpContextWrapper(HttpContext.Current));
            For<HttpServerUtilityBase>().Use(() => new HttpServerUtilityWrapper(HttpContext.Current.Server));
            
        }
    }
}