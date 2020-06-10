using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class 막대그래프cs
    {
        static void Main(string[] args)
        {
            string[] name = { "김서방", "나서방", "다서방", "라서방", "마서방", "바서방" };
            int[] score = { 66, 77, 99, 55, 88, 75 };


            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0} {1} ", name[i], score[i]);
                Print_Star(score[i]);
            }
        }

        static public void Print_Star(int i)
        {
            for(int j = 0; j< i/10; j++)
                Console.Write("*");

            switch (i / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine(" A");
                    break;

                case 8:
                    Console.WriteLine(" B");
                    break;

                case 7:
                    Console.WriteLine(" C");
                    break;

                case 6:
                    Console.WriteLine(" D");
                    break;

                default:
                    Console.WriteLine(" F");
                    break;
            }

        }

    }
}
