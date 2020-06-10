using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class 성적처리_4
    {
        static void Main(string[] args)
        {
            int[,] jumsu = new int[4, 7] { { 1, 33, 44, 55, 0, 0, 1 }, { 2, 77, 88, 99, 0, 0, 1 }, { 3, 55, 66, 77, 0, 0, 1 }, { 4, 87, 88, 89, 0, 0, 1 } };
            string[] name = new string[] { "KBS", "SBS", "YTN", "MBC" };

            Score(jumsu); //점수 계산

            Rank(jumsu); //석차 계산

            Sort(jumsu, name);

            Console.WriteLine("학번\t이름\t국\t영\t수\t총점\t평균\t석차");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j == 1)
                        Console.Write("{0}\t", name[i]);
                    Console.Write("{0}\t", jumsu[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Score(int[,] jumsu)
        {
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
        }

        static void Rank(int[,] jumsu)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (jumsu[i, 4] == jumsu[j, 4])
                        continue;

                    else if (jumsu[i, 4] > jumsu[j, 4])
                        jumsu[j, 6]++;

                    else
                        jumsu[i, 6]++;
                }
            }
        }

        static void Sort(int[,] jumsu, string[] name)
        {
            int[] temp = new int[7];
            string tmp;

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (jumsu[i, 6] > jumsu[j, 6])
                    {
                        for (int k = 0; k < 7; k++) 
                        {
                            temp[k] = jumsu[i,k];
                            jumsu[i,k] = jumsu[j,k];
                            jumsu[j,k] = temp[k];
                        }

                        tmp = name[i];
                        name[i] = name[j];
                        name[j] = tmp;
                        
                    }
                }
            }
        }
    }
}
