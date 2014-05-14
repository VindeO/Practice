using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.MVC5.DI.SM.Registries
{
    public class StructureMapStandardRegistry:Registry
    {
        public StructureMapStandardRegistry()
        {
            Scan(scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}