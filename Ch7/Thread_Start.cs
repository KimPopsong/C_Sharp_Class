using System;
using System.Threading; // 추가 

class Thread_Start
{
    static void Func_A()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("A : Count = " + i);
        }
    }
    static void Func_B()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("B : Count = " + i);
        }
    }

    static void Func_C()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("C : Count = " + i);
        }
    }
    static void Main(string[] args)
    {
        Thread th_a = new Thread(Func_A);  // FuncA 는 델리게이트
        Thread th_b = new Thread(Func_B);  //Thread는 클래스 이름
        Thread th_c = new Thread(Func_C);
        th_a.Start();  // Thread 를 동작시킴
        th_b.Start();  // Thread 를 동작시킴
        th_c.Start();  // Thread 를 동작시킴
    }
}



