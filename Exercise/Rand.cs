using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Rand
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] t = new int[50];

            for (int i = 0; i < 50; i++)
            {
                t[i] = r.Next(1, 10);
                Console.WriteLine(t[i]);
            }
        }
    }
}
