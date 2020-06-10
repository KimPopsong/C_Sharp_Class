using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Hap_Min_Max_Aver
    {
        static void Main(string[] args)
        {
            int Max = 0, Min = 10;
            int Sum = 0, Ave = 0;

            int[] su = new int[7] { 1, 3, 5, 7, 2, 4, 6 };

            for(int i=0;i<su.Length;i++)
            {
                if (su[i] > Max)
                    Max = su[i];

                if (su[i] < Min)
                    Min = su[i];

                Sum += su[i];
            }

            Ave = Sum / su.Length;

            Console.WriteLine("Sum = {0}, Max = {1}, Min = {2}, Ave = {3}", Sum, Max, Min, Ave);
        }
    }
}
