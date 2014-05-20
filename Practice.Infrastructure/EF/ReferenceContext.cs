using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Core.Domain;
using System.Data.Entity;
namespace Practice.Infrastructure.EF
{
    public class ReferenceContext:BaseContext<ReferenceContext>
    {
        public DbSet<ProductReference> Products { get; set; }
        public DbSet<CustomerReference> Customers { get; set; }
    }
}
