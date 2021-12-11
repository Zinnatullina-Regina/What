using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(20, -7);
            Complex c2 = new Complex(1, 1);
            Console.WriteLine(c1 * c2);




            Console.ReadKey();
        }
    }
}
