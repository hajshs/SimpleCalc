using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstnumber, secondnumber;
            string operation;
            double total;

            Console.Write("First Number: ");
            firstnumber = float.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            secondnumber = float.Parse(Console.ReadLine());
            Console.Write("Operation: ");
            operation = Console.ReadLine();

            if (operation == "addition")
            {
                total = firstnumber + secondnumber;
                Console.WriteLine($"Total: {total}");
            }
            else if (operation == "subtraction")
            {
                if (firstnumber < secondnumber)
                {
                    total = secondnumber - firstnumber;
                    Console.WriteLine($"Total: -{total}");
                }
                else
                {
                    total = (firstnumber - secondnumber);
                    Console.WriteLine($"Total: {total}");
                }
            }
            else if (operation == "multiplication")
            {
                total = firstnumber * secondnumber;
                Console.WriteLine($"Total: {total}");
            }
            else if (operation == "division")
            {
                if (firstnumber == 0)
                {
                    Console.WriteLine($"Total: 0");
                }
                else if (secondnumber == 0)
                {
                    Console.WriteLine($"Cannot divide by zero");
                }
                else
                {
                    total = firstnumber / secondnumber;
                    Console.WriteLine($"Total: {total}");
                }
            }
            else
            {
                Console.WriteLine($"Invalid Operation");
            }
            Console.ReadKey();
        }
    }
}
