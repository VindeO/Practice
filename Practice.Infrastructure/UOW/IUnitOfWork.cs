using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.UOW
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        int Save();
        TContext Context { get; }
    }
}
