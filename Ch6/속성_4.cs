using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    public class SAram
    {
        private string _Name; // 첫자 대문자에 _  씀
        private int _Age;     // 첫자대문자에 _ 씀

        public string Name   // 속성 ()가 없다.          
        {
            get { return _Name; }   // get  -읽어올때
            set { _Name = value; }  // set - 저장할때 
        }                     //value 키워드

        public int Age       //속성-- 괄호가 없다.
        {
            get { return _Age; }  //get - 읽어올 때
            set { _Age = value; } //set - 저장할때
        }
    }
    class 속성_5
    {
        public static void Main()
        {
            SAram c = new SAram();
            c.Name = "강감찬이다";
            c.Age = 889;

            Print(c.Name, c.Age);
        }
        private static void Print(string name, int age)
        {

            Console.WriteLine("이름은 {0}, 나이는 {1}  ",
                 name, age);
        }

    }
}
