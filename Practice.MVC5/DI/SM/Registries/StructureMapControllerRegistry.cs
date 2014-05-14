using Practice.MVC5.DI.SM.Conventions;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.MVC5.DI.SM.Registries
{
    public class StructureMapControllerRegistry : Registry
    {
        public StructureMapControllerRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.With(new StructureMapControllerConvention());
            });
        }
    }
}