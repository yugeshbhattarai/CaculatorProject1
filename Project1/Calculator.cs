using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Calculator
    {
        private double _num1;
        private double _num2;
        private string _op;
        private string _fileName = "YourLog";

        public double Num1 { get => _num1; set => _num1 = value; }
        public double Num2 { get => _num2; set => _num2 = value; }
        public string Op { get => _op; set => _op = value; }
        public string FileName { get => _fileName; set => _fileName = value; }

        public string Addition(double num1, double num2)
        {
            double result = num1 + num2;
            string resultString = "\n________________________________________________________________________________________________\n\n\n" + num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
            _op = "Addition: "+ num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
            AddtoLog(FileName, _op);
            return resultString;
        }

        public string Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            string resultString = "\n________________________________________________________________________________________________\n\n\n" + num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
            _op = "Subtraction: " + num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
            AddtoLog(FileName, _op);
            return resultString;

        }

        public string Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            string resultString = "\n________________________________________________________________________________________________\n\n\n" + num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
            _op = "Subtraction: " + num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
            AddtoLog(FileName, _op);
            return resultString;
        }
        public string Division(double num1, double num2)
        {
            double result;
            if (num2 == 0)
            {
                string c = "\n________________________________________________________________________________________________\n\n\n" + "Attempted "+ num1.ToString()+ " / " + num2.ToString()+  ". Warning! Cannot divide by 0.";

                _op = "Division: Attempted " + num1.ToString()+ " / " + num2.ToString()+  " . Warning! Cannot divide by 0.";
                AddtoLog(FileName, _op);
                return c;
            }

            else
            {
                result = num1 / num2;
                _op = "Division: " + num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
                AddtoLog(FileName, _op);
                if (num1 % num2 != 0)
                {
                    string c = "\n________________________________________________________________________________________________\n\n\n" + num1.ToString() + " / " + num2.ToString() + " reults as\nQuotient = " + ((int)result).ToString() + "\nRemainder = " + (num1 % num2).ToString() + "\nDecimal Result = " + (num1 / num2).ToString("0.000");
                  
                    return c;
                }
                else
                {
                    string d = "\n________________________________________________________________________________________________\n\n\n" + num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
                  
                    return d;
                }
                
            }
        }

        static void AddtoLog(string fileName, string a)
        {
            
            if (!File.Exists(fileName))
            {
                StreamWriter writer1 = new StreamWriter(fileName);
                writer1.WriteLine("Operation Log:");
                writer1.Write(DateTime.Now.ToString());
                writer1.Write("\tOperation Number: 1");
                writer1.Write("\t"+a);
                writer1.Close();
                
            }

            else
            {
                StreamWriter writer1 = File.AppendText(fileName);
                writer1.WriteLine();
                int count = TotalLines(fileName);
                writer1.Write(DateTime.Now.ToString());
                writer1.Write("\tOperation Number: " + (count));
                writer1.Write("\t"+ a);
                writer1.Close();
            
            }

        }
        static int TotalLines(string fileName)
        {
            File.Copy(fileName, "newLog.txt", true);
            int count = File.ReadAllLines("newLog.txt").Length;
            return count;
        }
    }
}
