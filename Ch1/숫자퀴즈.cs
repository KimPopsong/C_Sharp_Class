using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    class 숫자퀴즈
    {
        /*
        public int Chk(int a)
        {

        }
        */
        static void Main(string[] args)
        {
            Random rnd = new Random(); //랜덤 객체 rnd생성

            int answer = rnd.Next(1, 101); // 1 ~ 100까지 난수 생성
            int cnt = 0; //입력 횟수

            while(true) //입력받은 수와 랜덤값이 같을 때 탈출
            {
                int me; //입력 받은 수

                Console.Write("수 입력 : ");

                cnt++; //시도 횟수 카운트
                me = Convert.ToInt32(Console.ReadLine()); //me함수에 정수 입력

                if(me == answer) //같을 때
                {
                    Console.WriteLine("정답!");
                    Console.WriteLine("시도 횟수 : {0}", cnt); //시도 횟수 출력
                    break; //종료
                }

                else if(me > answer) //입력 값이 클 때
                {
                    Console.WriteLine("큼!");
                }

                else //입력 값이 작을 때
                {
                    Console.WriteLine("작음!");
                }
            }

        }
    }
}
