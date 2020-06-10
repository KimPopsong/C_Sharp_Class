using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class Total
    {
        static void Main(string[] args)
        {
            int cnt = 0, odd = 0, even = 0, odd_sum = 0, even_sum = 0;
            int input;

            //while문

            Console.Write("정수 입력 : ");

            while((input = Convert.ToInt32(Console.ReadLine())) != -1)
            {
                cnt++;

                if (input % 2 == 0)
                {
                    even++;
                    even_sum += input;
                }

                else
                {
                    odd++;
                    odd_sum += input;
                }
                    

                Console.Write("정수 입력 : ");
            }

            //do while문

            do
            {
                Console.Write("정수 입력 : ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                    break;

                else if (input % 2 == 0)
                {
                    even++;
                    even_sum += input;
                }

                else
                {
                    odd++;
                    odd_sum += input;
                }

                cnt++;
            } while (input != -1);

            //for문

            for (; ; )
            {
                Console.Write("정수 입력 : ");
                input = Convert.ToInt32(Console.ReadLine());

                if(input == -1)
                    break;

                else if (input % 2 == 0)
                {
                    even++;
                    even_sum += input;
                }

                else
                {
                    odd++;
                    odd_sum += input;
                }
                cnt++;
            }

            Console.WriteLine("데이터의 개수 : {0}", cnt); 
            Console.WriteLine("짝수의 합 & 개수 : {0}, {1}", even_sum, even);
            Console.WriteLine("홀수의 합 & 개수 : {0}, {1}", odd_sum, odd);
        }
    }
}
