using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.MVC5.Tasks;
namespace Practice.MVC5
{
    public class TransactionPerRequest : IRunOnEachRequest,IRunOnError,IRunAfterEachRequest
    {
        void IRunOnEachRequest.Execute()
        {
            throw new NotImplementedException();
        }
        void IRunOnError.Execute()
        {
            throw new NotImplementedException();
        }
        void IRunAfterEachRequest.Execute()
        {
            throw new NotImplementedException();
        }      
    }
}