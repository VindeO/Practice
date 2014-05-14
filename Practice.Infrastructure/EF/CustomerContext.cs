using Practice.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.EF
{
    public class CustomerContext:BaseContext<CustomerContext>
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
          //  modelBuilder.Configurations.Add(new LineItemMap());
            modelBuilder.Entity<Customer>();
            modelBuilder.Ignore<Category>();
        }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            return base.ValidateEntity(entityEntry, items);
        }
    }
}
