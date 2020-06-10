using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    class GBB
    {
        static void Main(string[] args)
        {
            int answer = GBB_Check.Rnd(); // 1 ~ 100까지 난수 생성
            int cnt = 0; //입력 횟수

            while (true) //입력받은 수와 랜덤값이 같을 때 탈출
            {
                int me; //입력값
                int chk; //Check함수에서 리턴

                Console.Write("수 입력 : ");

                cnt++; //시도 횟수 카운트

                me = GBB_Check.Inp(); //me변수에 정수 입력, 입력값

                chk = GBB_Check.Check(me, answer); //me와 answer비교, 입력값과 답 비교

                if(chk == 1)
                {
                    Console.WriteLine("정답!");
                    Console.WriteLine("시도 횟수 : {0}", cnt); //시도 횟수 출력
                    break; //종료
                }

                else if(chk == 2)
                {
                    Console.WriteLine("큼!");
                }

                else
                {
                    Console.WriteLine("작음!");
                }
            }
        }
    }
}
