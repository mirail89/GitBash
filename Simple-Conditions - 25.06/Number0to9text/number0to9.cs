using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to9text
{
    class number0to9
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("null");
            else if (num == 1)
                Console.WriteLine("one");
            else if (num == 2)
                Console.WriteLine("two");
            else if (num == 3)
                Console.WriteLine("three");
            else if (num == 4)
                Console.WriteLine("four");

                Console.WriteLine("number too big");
        }
    }
}
