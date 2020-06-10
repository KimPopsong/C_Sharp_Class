using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    class 두_수의_합
    {
        static void Main(string[] args)
        {
            string s1, s2;

            Console.Write("s1 입력 : "); //Input s1
            s1 = Console.ReadLine();

            Console.Write("s2 입력 : "); //Input s2 
            s2 = Console.ReadLine();

            int i1 = Convert.ToInt32(s1) + Convert.ToInt32(s2);

            Console.WriteLine("{0}과 {1}의 합은 = " + (s1 + s2), s1, s2); //String    
            Console.WriteLine("{0}과 {1}의 합은 = " + i1, s1, s2); //Int
        }
    }
}
