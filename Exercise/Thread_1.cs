using System;
using System.Threading;

namespace Exercise
{
    class Thread_1
    {
        static void FuncA()
        {
            for (int i = 0; i < 10000; i++)
                Console.WriteLine("A : Count  A= " + i);
        }

        static void FuncB()
        {
            for (int i = 0; i < 10000; i++)
                Console.WriteLine("B : Count  B= " + i);
        }

        static void Main(string[] args)
        {
            Thread th_a = new Thread(FuncA);  // FuncA 는 델리게이트
            Thread th_b = new Thread(FuncB);  //Thread는 클래스 이름
            th_a.Start();  // Thread 를 동작시킴
            th_b.Start();
        }
    }
}
