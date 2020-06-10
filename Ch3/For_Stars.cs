using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class For_Stars
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                Console.Write("*");
            Console.WriteLine();

            Console.WriteLine();

            for (int i = 0; i < 5; i++)         
                Console.WriteLine("*");
            Console.WriteLine();

            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)        
                    Console.Write("*");                
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++) 
            {
                for (int j = 5; j >= 5 - i; j--) 
                    Console.Write("*"); ;
                Console.WriteLine();
            }
        }
    }
}
