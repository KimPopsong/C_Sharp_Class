using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class 속성
    {
        public static void Main(string[] args)
        {
            //[1] 절차 지향에서 고전적인 방법
            string name = "절차지향방법";    // 지역변수 사용
            int age = 20;
            Print(name, age);
        }

        private static void Print(string name, int age)
        {
            Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);
        }
    }
}
