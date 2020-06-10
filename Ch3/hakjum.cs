using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class Hakjum
    {
        static void Main(string[] args)
        {
            int score = 0;

            while (score != -999)
            {
                Console.Write("점수 입력 : ");
                score = Convert.ToInt32(Console.ReadLine());

                if (score > 100 || score < 0) //범위
                {
                    Console.WriteLine("ERROR");
                    continue;
                }

                Console.WriteLine("학점 : {0}", Check(score));
            }
        }

        public static string Check(int score)
        {
            switch (score / 10)
            {
                case 10:
                case 9:
                    return "A";

                case 8:
                    return "B";

                case 7:
                    return "C";

                case 6:
                    return "D";

                default:
                    return "F";
            }
        }
    }
}