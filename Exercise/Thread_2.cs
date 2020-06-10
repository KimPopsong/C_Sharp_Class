using System;
using System.Threading;

namespace Exercise
{
    class Thread_2
    {
        static Thread th_x = new Thread(FuncA);
        static Thread th_y = new Thread(FuncB);

        static void FuncA()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i > 3)
                {
                    th_x.Abort();  // 해당 스레드 종료 함
                }
                Console.WriteLine("A : Count = " + i);
            }
        }

        static void FuncB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("B : Count = " + i);
            }
        }

        static void Main(string[] args)
        {
            th_x = new Thread(FuncA);
            th_y = new Thread(FuncB);
            th_x.Start();
            th_y.Start();
        }
    }
}
