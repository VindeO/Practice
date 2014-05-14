using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Configuration.DSL.Expressions;
using StructureMap.TypeRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.MVC5.DI.SM.Registries
{
    public class StructureMapActionFilterRegistry : Registry
    {
        private readonly Func<IContainer> _container;
        public StructureMapActionFilterRegistry(Func<IContainer> containerFactory)
        {
            For<IFilterProvider>().Use(new StructureMapFilterProvider(containerFactory));
           // SetAllProperties(x =>
            //    x.M);
        }
    }
}