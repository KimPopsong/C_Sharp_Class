using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class mbc    // 클래스 이름 mbc
    {
        private string name;       
        private int age;
        public mbc(string irum)
        {
            this.name = irum;
        }
        public mbc(int nayi)
        {
            this.age = nayi;
        }
        public mbc(string irum, int nayi)
        {
            this.name = irum;
            this.age = nayi;
        }
        public void Out()
        {
            Console.WriteLine("Age = {0}", age);
        }
        public void Output()
        {
            Console.WriteLine("Name = {0}, Age = {1}", name, age);
        }
        public void Print()
        {
            Console.WriteLine("이름은 {0}", name);
        }
    }

    class 매개생성자
    {
        static void Main()
        {
            mbc k2 = new mbc("김팝송");
            k2.Print();

            mbc k3 = new mbc(77);
            k3.Out();

            mbc k4 = new mbc("김ㅁㄴㅇㄹ", 123);
            k4.Output();
        }

    }
}
