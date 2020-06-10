using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class _2차원배열
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 4] { { 10, 20, 30, 0 }, { 40, 50, 60, 0 } };

            for (int i = 0; i < 2; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += array[i,j];
                }

                array[i, 3] = sum;
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", array[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
