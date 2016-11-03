using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace testFody2
{
    class Program
    {
        [Interceptor]
        static void Main(string[] args)
        {
            Console.WriteLine("AAAA");

            try
            {
                string s = "a";
                var i = int.Parse(s);
                //throw new InvalidOperationException("Ooops");
            }
            catch
            {
                throw;
            }

        }

        [Interceptor]
        private void testMethod()
        {

        }

    }
}
