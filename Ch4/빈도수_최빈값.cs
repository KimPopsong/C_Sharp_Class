using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class 빈도수_최빈값
    {
        static void Main(string[] args)
        {
            int[] in_num = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //입력 숫자 보관
            int[] count = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //카운트 보관
            int cnt = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} 번째숫자 0부터 9 사이 값 10개 입력 : ", i);
                in_num[i] = Convert.ToInt32(Console.ReadLine());

                count[in_num[i]]++;

                if (cnt < count[in_num[i]])
                    cnt = in_num[i];
            }

            Console.WriteLine("\n입력값   빈도수\n");

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("{0}\t{1}", i, count[i]);
            }

            Console.WriteLine("최빈값은 {0}이 {1}번 나타남", cnt, count[cnt]);

        }
    }
}
