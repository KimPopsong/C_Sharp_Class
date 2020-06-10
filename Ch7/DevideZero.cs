using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7
{
    class DevideZero
    {
        static void Main(string[] args)
        {
            int i = 3, j = 0, k = 0;

            //k = 3 / 0;

            try
            {
                k = i / j;
            }
            
            catch(Exception t)
            {
                Console.WriteLine("Error");
                Console.WriteLine(t.Message);
            }

            finally
            {
                Console.WriteLine("k = {0}", k);
            }
        }
    }   
}
