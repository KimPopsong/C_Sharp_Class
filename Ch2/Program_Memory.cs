using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    class Program_Memory
    {
        static int num1 = 1;  // 전역 변수 : 데이터 영역에 저장
        static int num2 = 2;  // 전역 변수 : 데이터 영역에 저장
                              // Main 이 끝날 때까지 유지
        static void Main(string[] args)
        {
            int arg = 10;  // 지역젼수 : 스택영역에 저장했다가
                           //  Main 이 끝날 때까지 유지
            func1(arg);  // 11  스택영역에 저장
            func2(arg);  // 12  스택영역에 저장 
        }
        static void func1(int arg1)
        {
            arg1 = arg1 + num1;  // 스택에 저장했다가 func1 벗어나면서 소멸됨.
            Console.WriteLine(arg1);
        }
        static void func2(int arg2)
        {
            arg2 = arg2 + num2; // 스택에 저장했다가 func2 벗어나면서 소멸됨.
            Console.WriteLine(arg2);
        }
    }

}
