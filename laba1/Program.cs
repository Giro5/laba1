using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
            
          {
            double y, s, a, b, t;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("t = ");
            t = Convert.ToDouble(Console.ReadLine());
            y = (Math.Exp((-1) * b * t) * Math.Sin(a * t + b)) - Math.Sqrt(Math.Abs(b * t + a));
            s = b * Math.Sin(a * Math.Pow(t, 2) * Math.Cos(2 * t)) - 1;
            Console.Write("y = ");
            Console.WriteLine(y);
            Console.Write("s = ");
            Console.WriteLine(s);
            Console.ReadKey();
            
        }
    }
}
