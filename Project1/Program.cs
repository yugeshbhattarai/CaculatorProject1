using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closeProgram = false;
            Banner one = new Banner();
            Console.Title = "Calculator";

            while (!closeProgram)
            {
                //Reset the console
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                //StartBanner                
                Console.WriteLine(one.startBanner());
                Console.WriteLine("________________________________________________________________________________________________\n");

                //Display the Selection Option
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(one.Buildcalc());
                Console.ForegroundColor = ConsoleColor.Black;

                //Look for Type of Operation
                bool operatorSelector = false;
                while (!operatorSelector)
                {
                    //Create a calculator and Check validity of Number Entry
                    Calculator myCalculator = new Calculator();
                    NumChecker a = new NumChecker();
                    string op = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    if (op.ToUpper() == "A" || op.ToUpper() == "S" || op.ToUpper() == "M" || op.ToUpper() == "D")
                    {
                        switch (op.ToUpper())
                        {
                            case "A":
                                Console.WriteLine(one.AdditionBanner());
                                Console.WriteLine(myCalculator.Addition(a.num1check(), a.num2Check()));

                                break;
                            case "S":
                                Console.WriteLine(one.SubtractionBanner());
                                Console.WriteLine(myCalculator.Subtraction(a.num1check(), a.num2Check()));

                                break;
                            case "M":
                                Console.WriteLine(one.MultiplicationBanner());
                                Console.WriteLine(myCalculator.Multiplication(a.num1check(), a.num2Check()));

                                break;
                            case "D":
                                Console.WriteLine(one.DivisionBanner());
                                Console.WriteLine(myCalculator.Division(a.num1check(), a.num2Check()));

                                break;
                        }

                        operatorSelector = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input the correct letter corresponding to the desired operation: ");
                    }
                }

                Console.WriteLine("\n________________________________________________________________________________________________\n\nDo you wish to continue to use the calculator?\nY-Yes\nPress any key to quit the application ");


                if (Console.ReadLine().ToUpper() != "Y")
                    closeProgram = true;
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(one.endProgramBanner());
        }


    }
}


