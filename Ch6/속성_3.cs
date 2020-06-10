using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    public class Saram
    {
        private string name;
        private int age;
        public string GetName()
        { // public  한 반환 메소드
            return this.name;
        }
        public int GetAge()
        {  // public  한 반환 메소드
            return this.age;
        }
        public Saram(string s, int i)
        {  // 매개변수 있는 생성자  set 기능
            this.name = s; this.age = i;
        }     // 필드값을 초기화
    }

    class 속성_3
    {
        static void Main(string[] args)
        {
            Saram c = new Saram("강감찬", 888);
            Print(c.GetName(), c.GetAge());
        }

        private static void Print(string name, int age)
        {
            Console.WriteLine("이름은 {0},  나이는 {1}", name, age);
        }
    }
}
