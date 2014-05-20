using Practice.Core.Domain;
using Practice.Core.IRepositories;
using Practice.Infrastructure.EF;
using Practice.Infrastructure.UOW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Practice.Infrastructure.EF.Helpers;

namespace Practice.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;
  
        public CustomerRepository(CustomerContextUOW uow)
        {
            _context = uow.Context;
        }
        //IQueryable allows to add LINQ queries to filter the data
        public IQueryable<Customer> All
        {
            get { return _context.Customers; }
        }

        public List<Customer> AllCustomers
        {
            get { return _context.Customers.ToList(); }
        }
        public List<Customer> AllCustomersWhoHaveOrdered
        {
            get { return _context.Customers.Where(c => c.Orders.Any()).ToList(); }
        }

        public IQueryable<Customer> AllIncluding(params Expression<Func<Customer, object>>[] includeProperties)
        {
            IQueryable<Customer> query = _context.Customers;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Customer Find(int id)
        {
            return _context.Customers.Find(id);
        }
      

        public void InsertOrUpdate(Customer customer)
        {
            
            //if (customer.Id == default(int))
            //{
            //    Alll the objects in the graph will get updated to EntityState.Added (Orders,Addresses)
            //   
            //    _context.Customers.Add(customer);
            //}
            //else
            //{
            //    Only Cutomer EntityStated is set to Modified, but not the Orders, Address
            //    _context.Entry(customer).State = EntityState.Modified;
            //}
            if (customer.Id == default(int)) // New entity
            {
                _context.Entry(customer).State = EntityState.Added;  //Context insert
            }
            else        // Existing entity
            {
                //If we add a new Address without involving Context it will throw errors ( Address's CustomerId , Customer will be null )
                //_context.Customers.Add(customer);
                _context.Entry(customer).State = EntityState.Modified; //Context update

            }
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            _context.Customers.Remove(customer);
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public void InsertOrUpdateGraph(Customer customerGraph)
        {
            if (customerGraph.State == State.Added)
            {
                _context.Customers.Add(customerGraph);
            }
            else
            {
                _context.Customers.Add(customerGraph);
                _context.ApplyStateChanges();
            }
        }
    }
}
