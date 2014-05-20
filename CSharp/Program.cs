using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var web = new WebClient();
            string result = web.DownloadString("");
            //This is not Asynchronous 
            Task<string> getTask = Task<String>.Factory.StartNew(() =>
            {
                string tresult = web.DownloadString("");
                return tresult;
            });

            getTask.ContinueWith(t =>
            {
                Console.WriteLine(getTask.Result);
            });

            string r;
            Thread.Sleep(5000);
            Console.WriteLine(result);

        }
    }
}
