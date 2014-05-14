using Practice.MVC5.Tasks;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.MVC5.DI.SM.Registries
{
    public class StructureMapTaskRegistry:Registry
    {
        public StructureMapTaskRegistry()
        {
            Scan(scan =>
                {
                    scan.AssembliesFromApplicationBaseDirectory(
                        a => a.FullName.StartsWith("Practice"));
                    scan.AddAllTypesOf<IRunAtInit>();
                    scan.AddAllTypesOf<IRunAtStartup>();
                    scan.AddAllTypesOf<IRunOnEachRequest>();
                    scan.AddAllTypesOf<IRunOnError>();
                    scan.AddAllTypesOf<IRunAfterEachRequest>();
                });
        }
    }
}