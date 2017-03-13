using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Calculator
    {
        public delegate double calculator(double x, double y);

        static void menu()
        {
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter e to Exit");
        }
        static double addition(double x, double y)
        {
            return x + y;
        }
        static double subtraction(double x, double y)
        {
            return x - y;
        }
        static double multiplication(double x, double y)
        {
            return x * y;
        }
        static double division(double x, double y)
        {
            return x / y;
        }
        static void main2(string[] args)
        {
            char operation;
            calculator cal = (delegate (double xx, double yy) { return 0; });
            double x, y;


            do
            {
                Console.WriteLine("Enter twi numbers seprated by ENTER");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Clear();
                operation = char.Parse(Console.ReadLine());

                menu();

                switch (operation)
                {
                    case '+':
                        cal = new calculator(addition);
                        break;

                    case '-':
                        cal = new calculator(subtraction);
                        break;

                    case '*':
                        cal = new calculator(multiplication);
                        break;

                    case '/':
                        cal = new calculator(division);
                        break;

                }

                Console.WriteLine(cal(x, y));
                Console.WriteLine("Press any kewy to continue");
                Console.ReadKey(true);
                Console.Clear();
            } while (operation != 'e');

        }
    }
}



