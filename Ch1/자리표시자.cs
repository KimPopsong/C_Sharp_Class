using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    class 자리표시자
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int hap = 0;
            hap = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, hap);
            Console.WriteLine(a + " + " + b + " = " + hap);
            Console.WriteLine(3 + " 더하기 " + 4 + "는 " + 7 + "입니다.");
        }
    }
}
