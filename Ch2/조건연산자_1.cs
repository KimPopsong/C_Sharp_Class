using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    class 조건연산자_1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int min, max;

            Console.Write("1번째 수 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2번째 수 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3번째 수 : ");
            c = Convert.ToInt32(Console.ReadLine());
          
            min = a;
            max = c;

            if(a < b || a < c) //max값 찾기
            {
                if (b < c)
                    max = c;

                else
                    max = b;
            }

            if (a < c || b < c) //min값 찾기
            {
                if (a < b)
                    min = a;

                else
                    min = b;
            }

            Console.WriteLine("MAX = {0}", max);
            Console.WriteLine("MIN = {0}", min);
        }
    }
}
