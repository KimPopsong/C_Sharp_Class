using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7
{
    class Throw
    {
        static void Main(string[] args)
        {
            int i = 3, j = 0;
            int k;

            j = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (j != 0)
                    k = i / j;

                else
                    throw new Exception("0 오면 안뎀");
            }

            catch(Exception p)
            {
                Console.WriteLine(p.Message);
            }

            finally
            {
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}
