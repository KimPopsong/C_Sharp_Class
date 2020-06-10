using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Method
    {
        public static void Main(string[] args)
        {
            NewMethod();

            Hi("죽은 메소드 이런 메소드 절대 사용하지 말 것");

            int value = Plus(3, 5);

            Console.WriteLine("반환값이 있는 메소드 3 + 5 = {0}", value);
        }

        private static int Plus(int v1, int v2)
        {
            int res = v1 + v2;
            return res;
        }

        private static void Hi(string v)
        {
            Console.WriteLine(v);
        }

        private static void NewMethod()
        {
            Console.WriteLine("매개변수와 반환 값이 없는 메소드 ");
        }
    }
}
