using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    class 형변환
    {
        static void Main(string[] args)
        {
            string s = "123";
            float f = 321;
            int hap;

            hap = (int)f + Convert.ToInt32(s);

            Console.WriteLine(hap);
        }
    }
}
