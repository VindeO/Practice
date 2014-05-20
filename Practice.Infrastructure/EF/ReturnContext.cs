using Practice.Core.Domain;
using Practice.Infrastructure.EF.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.EF
{
    public class ReturnContext:BaseContext<ReturnContext>
    {
        public DbSet<Return> Returns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new LineItemMap());
            modelBuilder.Ignore<Customer>();
            modelBuilder.Ignore<Category>();
        }
    }
}
