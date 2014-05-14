using Practice.Core.IRepositories;
using Practice.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.Repositories
{
   public  class CustomerRepository:ICustomerRepository
    {
       private readonly CustomerContext _context;

       public CustomerRepository(CustomerContext context)
       {
           _context = context;
       }
        public IQueryable<Core.Domain.Customer> All
        {
            get {return _context.Customers; }
        }

        public IQueryable<Core.Domain.Customer> AllIncluding(params System.Linq.Expressions.Expression<Func<Core.Domain.Customer, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Core.Domain.Customer Find(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Core.Domain.Customer entity)
        {
           if(entity.Id == default(int))
           {
               _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
           }
           else
           {
               _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
           }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void InsertGraph(Core.Domain.Customer customer)
        {
            _context.Customers.Add(customer);
        }
    }
}
