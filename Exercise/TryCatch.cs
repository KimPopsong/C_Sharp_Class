using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("a 입력 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b 입력 : ");
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (b != 0)
                {
                    a = a / b;
                }

                else
                {
                    throw new Exception("b가 0임");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine(a);
            }

        }
    }
}
