using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class NumChecker
    {
        double number1;
        double number2;
        bool select1 = false;
        bool select2 = false;
        public double num1check()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (!select1)
            {
                Console.Write("\nEnter a number and press Enter: ");

                if (double.TryParse(Console.ReadLine(), out number1))
                {

                    select1 = true;
                    return number1;
                }
                else
                {
                    select1 = false;
                }
            }

            number1 = double.Parse(Console.ReadLine());
            return number1;
        }

        public double num2Check()
        {
            while (!select2)
            {

                Console.Write("\nEnter another number and press Enter: ");

                if (double.TryParse(Console.ReadLine(), out number2))
                {
                    select2 = true;
                    return number2;
                }
                else
                {
                    select2 = false;
                }
            }

            number2 = double.Parse(Console.ReadLine());
            return number2;
        }
    }
}


