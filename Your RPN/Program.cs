using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.revPolNat("(3+4)*4"));
            Console.WriteLine(Class1.polNattoAnr(Class1.revPolNat("(3+4)*4")));
            Console.ReadKey();
        }
    }
}
