using Practice.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.UOW
{
    public class CustomerContextUOW:IUnitOfWork<CustomerContext>
    {
        private readonly CustomerContext _context;

        public CustomerContextUOW()
        {
            _context = new CustomerContext();
        }

        public CustomerContextUOW(CustomerContext context)
        {
            _context = context;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        public CustomerContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
