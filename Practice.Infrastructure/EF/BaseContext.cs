using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.EF
{
    public class BaseContext<TContext> :
        DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext()
            :base("name=ConnectionStringName")
        { }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
