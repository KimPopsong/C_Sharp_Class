using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class sbs    // 클래스 이름 sbs
    {
        private static string name = "홍서방";       // 3 감추어진 필드에 접근 
        private static int age = 19;

        public static void Print()           //   2 공개 된 메소드를 통해서만 가능 
        {
            Console.WriteLine("정적 이름은: {0}  정적 나이는 {1} ", name, age);
        }
    }

    class 생성자
    {
        static void Main(string[] args)
        {
            sbs.Print();   
        }
    }

}
