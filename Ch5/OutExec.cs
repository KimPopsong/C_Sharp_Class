using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class OutExec
    {
        public static void Exchange(float won, out float Doller, out float Yen)
        {
            Doller = won / 1100;  // return  사용 안함 – 주소에 데이터가 바뀌어 있음
            Yen = won / 10;  // 주소에 데이터가 바뀌어 있음     
        }

        static void Main(string[] args)
        {
            float won; float Doller; float Yen;

            Console.Write("환산할 금액을 입력하세요 : ");

            won = Convert.ToSingle(Console.ReadLine());

            Exchange(won, out Doller, out Yen);

            Console.WriteLine("달러로 환산한 금액은 {0}", Doller);
            Console.WriteLine("엔화로 환산한 금액은 {0}", Yen);
        }

    }
}
