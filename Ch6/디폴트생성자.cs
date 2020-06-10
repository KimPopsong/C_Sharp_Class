using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class kbs    // 클래스 이름 kbs
    {
        public void PrintAge()
        {
            Console.WriteLine("PrintAge 메소드 호출");
        }

        public kbs()  // 매개변수 없는 생성자는 :Default 생성자는 생략 가능
        {
            Console.WriteLine("Default 생성자 호출");
        }
    }

    class 디폴트생성자
    {
        static void Main(string[] args)
        {                                 //  new 순간 클래스를 메모리에 올리는 작업 
            kbs k1 = new kbs();    //  이 순간 생성자  kbs() 호출 - 매개변수 없음 
            k1.PrintAge();
        }
    }
}
