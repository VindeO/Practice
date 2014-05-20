using Practice.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Core.IRepositories
{
    public interface IReferenceRepository:IDisposable
    {
        IQueryable<ProductReference> Products { get; }
        IQueryable<CustomerReference> Customers { get; }

    }
}
