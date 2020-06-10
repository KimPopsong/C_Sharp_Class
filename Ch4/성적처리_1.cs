using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class 성적처리_1
    {
        static void Main(string[] args)
        {
            int[,] jumsu = new int[4, 7] { { 1, 33, 44, 55, 0, 0, 0 }, { 2, 77, 88, 99, 0, 0, 0 }, { 3, 55, 66, 77, 0, 0, 0 }, { 4, 87, 88, 89, 0, 0, 0 } };
            
            for (int i = 0; i < 4; i++) 
            {
                int score = 0, ave = 0;

                for (int j = 1; j < 4; j++) 
                {
                    score += jumsu[i, j];
                }
                jumsu[i, 4] = score;
                ave = score / 3;

                jumsu[i, 5] = ave;

            }

            Console.WriteLine("학번\t국\t영\t수\t총점\t평균\t석차");

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0}\t", jumsu[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
