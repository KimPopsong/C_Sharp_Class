using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    public class SARam
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class 속성_4
    {
        public static void Main()
        {
            SARam c = new SARam();
            c.Name = "강감찬이다";
            c.Age = 889;

            Print(c.Name, c.Age);
        }
        private static void Print(string name, int age)
        {

            Console.WriteLine("이름은 {0}, 나이는 {1}  ", name, age);
        }

    }
}
