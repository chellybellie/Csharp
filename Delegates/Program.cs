using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Operation(string word);
        static void PrintUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        static void PrintLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }
        static void print(string word)
        {
            Console.WriteLine(word);
        }
        static void Replacement(string word)
        {
            Console.WriteLine(word.Replace(' ', '.'));
        }


        class Calculator
        {
            public delegate double calculator(double x, double y);

            static void menu()
            {
                Console.WriteLine("input an operator");
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

    

            static void Main(string[] args)
            {
               ////PA system////
                Operation Op;

                Op = PrintUpper;
                Op += PrintLower;
                Op += print;
                Op += Replacement;

                Op("John Madden for President 2020");

                Console.ReadLine();
                DateTime oldTime = DateTime.Now;
                float deltaTime = (float)((DateTime.Now - oldTime).TotalSeconds);
                oldTime = DateTime.Now;

                ////Calculator////
                char operation;
                calculator cal = (delegate (double xx, double yy) { return 0; });
                double x, y;

                do
                {
                    Console.WriteLine("Enter two numbers seprated by ENTER");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    Console.Clear();
                 

             
                    menu();
                     string inpt =  Console.ReadLine();
                    operation = inpt[0];
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
}

