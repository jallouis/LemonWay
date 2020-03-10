using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient())
                {
                    Console.Write(obj.Fibonacci(10));
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
