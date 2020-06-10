using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7
{
    class exe
    {
       static void Main(string[] args)
       {
            ASDF f = new ASDF();
            f.a = 8;

            Asd(f);

            Console.WriteLine(f.a);
       }

       static void Asd(ASDF c)
       {
            c.a = 6;
       }
    }
    
    class ASDF
    {
        public int a;
    }
}
