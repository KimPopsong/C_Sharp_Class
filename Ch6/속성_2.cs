using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    public class saram  //구조체선언
    {
        private string name;
        private int age;
        // 반드시 public 으로 선언되어야 함

        public saram() { }
        public saram(int n, string p)
        {
            this.name = p;
            this.age = n;
        }
        public void Print()
        {
            Console.WriteLine("이름은 {0}, 나이는 {1}", name, age);
        }
        
        public void Set_name(string p)
        {
            this.name = p;
        }
        public void Set_age(int a)
        {
            this.age = a;
        }
    }   //  객체 지향언어의 구조체는 메소드 포함

    class 속성_2
    {
        public static void Main()
        {
            //[2] 구조체 사용
            saram a = new saram(); // 객체 a 생성
            a.Set_age(12);
            a.Set_name("김길동");
            a.Print();

            saram b = new saram(10, "박길동"); // 객체 b 생성
            b.Print();
        }

    }
}
