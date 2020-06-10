using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class _1차원배열
    {
        static void Main(string[] args)
        {
            // 선언 및 할당, 초기화
            int[] Age = new int[5] { 2, 4, 6, 8, 10 };
            Console.WriteLine(Age[0]);
            Console.WriteLine(Age[1]);
            Console.WriteLine(Age[2]);
            Console.WriteLine(Age[3]);
            Console.WriteLine(Age[4]);

            int sum = 0, four = 0;

            for (int i = 0; i < Age.Length; i++)
                sum += Age[i];

            Console.WriteLine("합 : {0}", sum);

            for(int i = 0; i < Age.Length; i++)
                  if (Age[i] % 4 == 0)
                    four += Age[i];
            Console.WriteLine("4 배수 : {0}", four);
        }
    }
}