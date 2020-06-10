using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 10; i++) //3단계
            {
                for(int j =1;j<10;j++)
                    Console.Write("{0} * {1} = {2:D2}   ", i, j, i*j);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i < 10; i++) //3단계
            {
                for (int j = 2; j < 10; j++)
                    Console.Write("{0} * {1} = {2:D2}   ", j, i, i * j);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i < 10; i++) //4단계
            {
                for (int j = 1; j < i + 1; j++)
                    Console.Write("{0} * {1} = {2:D2}   ", i, j, i * j);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i < 10; i += 3) //5단계, for문 2개
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0} * {1} = {2:D2}   ", i, j, i * j);
                    Console.Write("{0} * {1} = {2:D2}   ", i + 1, j, (i + 1) * j);
                    Console.WriteLine("{0} * {1} = {2:D2}", i + 2, j, (i + 2) * j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i < 10; i += 3) //5단계, for문 3개
            {
                for (int j = 1; j < 10; j++) 
                {
                    for (int k = i; k < i + 3; k++) 
                    {
                        Console.Write("{0} * {1} = {2:D2}   ", k, j, k * j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
