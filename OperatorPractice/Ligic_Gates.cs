using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPractice
{
    public class Logic_Gate
    {
        public void Logic_Gates()

        {
            int a = 0b111;
            int b = 0b110;

            var c = a & b;
            var d = a | b;
            var e = ~a;
            var f = ~(a & b);
            var g = ~(a | b);
            var h = a ^ b;
            var i = ~(a ^ b);
            Console.WriteLine($"AND of {a} , {b} is  {c}");
            Console.WriteLine($"OR of {a} , {b} is  {Convert.ToString(d, 2)}");
            Console.WriteLine($"NOT of {a} , {b} is  {e}");
            Console.WriteLine($"NAND of {a} , {b} is  {f}");
            Console.WriteLine($"NOR of {a} , {b} is  {g}");
            Console.WriteLine($"XOR of {a} , {b} is  {h}");
            Console.WriteLine($"XNOR of {a} , {b} is  {i}");
        }

    }
}
