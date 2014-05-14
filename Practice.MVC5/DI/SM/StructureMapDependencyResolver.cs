using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Practice.MVC5.DI.SM
{
    public class StructureMapDependencyResolver:IDependencyResolver
    {
        private readonly Func<IContainer> _container;
        public StructureMapDependencyResolver(Func<IContainer> container)
        {
            _container = container;
        }
        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }
            var container = _container();
            return serviceType.IsAbstract || serviceType.IsInterface
                ? container.TryGetInstance(serviceType) //If it is registered returns instacne if not null
                : container.GetAllInstances(serviceType); //S
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container().GetAllInstances(serviceType).Cast<object>();
        }
    }
}