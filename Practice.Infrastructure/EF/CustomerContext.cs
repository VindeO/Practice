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
            var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());

            ValidateCustomer(result);

            if (!result.IsValid)
            {
                return result;
            }
            return base.ValidateEntity(entityEntry, items);
        }

        private static void ValidateCustomer( DbEntityValidationResult result)
        {
            var customer = result.Entry.Entity as Customer;
            if (customer != null)
            {
                if (customer.EmailAddress == string.Empty)
                {
                    result.ValidationErrors.Add(new DbValidationError("EmailAddress", "EmailAddress Cannot be empty"));
                }
            }
        }
    }
}
