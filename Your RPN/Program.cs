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
            Console.WriteLine("Enter ordinary mathematical expression");
            string expression = Console.ReadLine();
            Console.WriteLine(Class1.revPolNat(expression));
            Console.WriteLine(Class1.polNattoAnr(Class1.revPolNat(expression)));
            Console.ReadKey();
        }
    }
}
