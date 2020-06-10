using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class Override
    {
        class Parent
        {
            public void Say()
            {
                Console.WriteLine("Parent said");
            }

            public void Hi()
            {
                Console.WriteLine("Parent Hi");
            }

            public virtual void Run()
            {
                Console.WriteLine("Parent Run");
            }
        }
        class Son : Parent
        {
            public void Say()
            {
                Console.WriteLine("Son said.");
            }

            public new void Hi()
            {
                Console.WriteLine("Son Hi");
            }

            public override void Run()
            {
                Console.WriteLine("Son Run");
            }
        }
    }
}
