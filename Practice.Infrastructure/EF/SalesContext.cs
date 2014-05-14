using Practice.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.EF
{
    public class SalesContext:BaseContext<SalesContext>
    {
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<LineItem> LineItems { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Payment> Payments { get; set; }
        public IDbSet<Category> Cateogries { get; set; }
        public IDbSet<Promotion> Promotions { get; set; }
    }
}
