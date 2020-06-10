using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class 가위바위보
    {
        static void Main(string[] args)
        {
            int c_r = 0, c_s = 0, c_p = 0;
            int cnt = 0, win = 0, lose = 0, draw = 0;

            Random now = new Random();
            int computer = now.Next(1, 4);

            int me = 0;

            while (me != -1)
            {
                Console.Write("1, 2, 3 중 하나의 수 입력 : "); //1 = 바위, 2 = 가위, 3 = 보, 4 = 바위
                me = Convert.ToInt32(Console.ReadLine());
                cnt++;

                switch(computer)
                {
                    case 1:
                        c_r++;
                        break;

                    case 2:
                        c_s++;
                        break;

                    case 3:
                        c_p++;
                        break;
                }

                switch (RSP(me, computer))
                {
                    case 1: //비김
                        Console.WriteLine("비김");
                        draw++;
                        break;

                    case 2: //이김
                        Console.WriteLine("이김");
                        win++;
                        break;

                    case 3: //짐
                        Console.WriteLine("짐");
                        lose++;
                        break;

                    default: //예외
                        Console.WriteLine("Error");
                        break;
                }
            }
            Console.WriteLine("총 게임 횟수 : {0}", cnt);
            Console.WriteLine("(컴퓨터의) 바위 : {0}, 가위 : {1}, 보 :{2}", c_r, c_s, c_p);
        }

        public static int RSP(int me, int computer)
        {
            if (me == 1) //me = 바위
            {
                switch (computer)
                {
                    case 1:
                        return 1;

                    case 2:
                        return 2;

                    case 3:
                        return 3;

                    default:
                        return 0;
                }

            }

            else if (me == 2) //me = 가위
            {
                switch (computer)
                {
                    case 1:
                        return 3;

                    case 2:
                        return 1;

                    case 3:
                        return 2;

                    default:
                        return 0;
                }
            }

            else if (me == 3) //me = 보
            {
                switch (computer)
                {
                    case 1:
                        return 2;

                    case 2:
                        return 3;

                    case 3:
                        return 1;

                    default:
                        return 0;
                }
            }

            else
            {
                return 0;
            }
        }
    }
}