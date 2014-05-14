using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Core.Domain;
namespace Practice.Core.IRepositories
{
    public interface ICustomerRepository:IEntityRepository<Customer>
    {
        void InsertGraph(Customer customer);
    }
}
