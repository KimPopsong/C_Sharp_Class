using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class Sbs    // 클래스 이름 sbs
    {
        private static string Name = "홍서방";       // [1]정적 멤버 은닉 
        private int Age = 19;                              // [2]인스턴스 멤버 은닉 = static 제거
        public static void Print_2()     // [1] 공개 된 메소드를 통해서만 가능 
        {
            Console.WriteLine("정적 이름은: {0} ", Name);
        }

        public void Out()   //[2] 공개된 메소드를 통해서만 접근
        {
            Console.WriteLine("인스턴스 나이는 : {0}", Age);
        }

        public Sbs()   // Default  생성자 – 없어도 무방함 
        {
            Console.WriteLine("Default  C#");
        }
    }

    class 생성자_2
    {
        static void Main(string[] args)
        {
            Sbs A = new Sbs();
            Sbs.Print_2();
            A.Out();
        }
    }
}
