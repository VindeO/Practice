using StructureMap.Graph;
using StructureMap.Pipeline;
using StructureMap.TypeRules;
using System;
using System.Web.Mvc;

namespace Practice.MVC5.DI.SM.Conventions
{
    public class StructureMapControllerConvention:IRegistrationConvention
    {
        public void Process(Type type, StructureMap.Configuration.DSL.Registry registry)
        {
            if (type.CanBeCastTo(typeof(Controller)) && !type.IsAbstract)
            {
                registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
            }
        }
    }
}