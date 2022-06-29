using System;

namespace SquareEquations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the coefficients of the square equation(ax^2 + bx + c = 0)");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            Console.WriteLine("Square root = \u221A");

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Each x is a solution.");
            }
            else if(a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine($"{c} = 0");
                Console.WriteLine("There is no solution to this equation.");
            }
            else if (a == 0 && b != 0 && c == 0)
            {
                Console.WriteLine($"{b}x = 0");
                Console.WriteLine("There is one solution to this equation: x = 0.");
            }
            else if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine($"{a}x^2 = 0");
                Console.WriteLine("There is one solution to this equation: x = 0.");
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                Console.WriteLine($"{a}x^2 + {b}x = 0");
                Console.WriteLine($"x*({a}x + {b}) = 0");
                Console.WriteLine($"There is two solutions to this equation: x = 0 and x = {-b*1.0/a}.");
            }
            else if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine($"{a}x^2 + {c} = 0");
                Console.WriteLine($"{a}x^2 = -({c})");
                Console.WriteLine($"x^2 = -({c}/{a})");
                if((-c/a)>0)
                {
                    double result = Math.Sqrt(-c*1.0 / a);
                    if(result == (int)result)
                    {
                        Console.WriteLine($"There is two solutions to this equation: x = {result} and x = {-result}.");
                    }
                    else
                    {
                        Console.WriteLine($"There is two solutions to this equation: x = \u221A{-c*1.0/a} ({result}) and x = -\u221A{-c * 1.0 / a} ({-result}).");
                    }
                }
                else
                {
                    Console.WriteLine($"There is no solution to this equation.");
                }
            }
            else if (a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine($"{b}x + {c} = 0");
                Console.WriteLine($"{b}x = -({c})");
                Console.WriteLine($"x = -({c}/{b})");
                Console.WriteLine($"There is one solution to this equation: x = {-c*1.0 / b}.");
            }
            
        }
    }
}
