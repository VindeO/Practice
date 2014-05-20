using Practice.Core.IRepositories;
using Practice.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.Repositories
{
    public class ReferenceRepository : IReferenceRepository
    {
        private readonly ReferenceContext _context;

        public ReferenceRepository()
        {
            _context = new ReferenceContext();
        }
        public IQueryable<Core.Domain.ProductReference> Products
        {
            get {return _context.Products.AsNoTracking(); }
        }

        public IQueryable<Core.Domain.CustomerReference> Customers
        {
            get { return _context.Customers.AsNoTracking(); }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
