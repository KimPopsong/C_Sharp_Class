using Sachik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class 네임스페이스연습
    {
        static void Main(string[] args)
        {
            // 0Sachik.hap_test h_t = new Sachik.hap_test();
            // hap_test h_t = new hap_test();

            hap_test.a = 6;
            hap_test.b = 4;

            int aa = hap_test.hap();

            Console.WriteLine("a + b = {0}", aa);
        }
    }
}