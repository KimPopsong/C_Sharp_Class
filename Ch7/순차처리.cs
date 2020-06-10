using System;

namespace Ch7
{
    class 순차처리
    {
        static void FuncA()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("A : Count  A= " + i);
        }

        static void FuncB()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("B : Count  B= " + i);
        }

        static void Main(string[] args)
        {
            FuncA(); FuncB();
        }
    }

}