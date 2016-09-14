using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_OOP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            int sum= summation(number1,number2);
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        public static int summation(int nm1,int nm2)
        {
            int result = nm1 + nm2;
            return result;
        }
    }
}
