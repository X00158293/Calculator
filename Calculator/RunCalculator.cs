using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTool
{
    class RunCalculator
    { 


        static void Main(string[] args)
        {

            Console.WriteLine("******                                   *******    ");
            Console.WriteLine("****** Running calculator functionality  *******    ");
            Calculator calc = new Calculator();

            Console.WriteLine("Please enter a number to check if it is special: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-> " + calc.IsSpecialNumber(number1));


            Console.WriteLine("Please enter a number to run an alternative calculation on it: ");
            double number2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("-> " + calc.AlternativeCalculate(number2));

            Console.Read();
        }
    }
}
