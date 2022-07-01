using System;
using System.Text;

namespace SquareEquations
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //SquareRootNumbers square = new SquareRootNumbers(144);
            //bool bool1 = square.IsWrong();
            //Console.WriteLine(bool1.ToString());
            //square.FindingNumOutsideTheRoot();
            //Console.WriteLine(square.ToString());


            Console.WriteLine();
            Console.WriteLine("Input the coefficients of the square equation(ax^2 + bx + c = 0)");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

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
                Console.WriteLine($"There is two solutions to this equation: x1 = 0 and x2 = {-b*1.0/a}.");
            }
            else if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine($"{a}x^2 + {c} = 0");
                Console.WriteLine($"{a}x^2 = -({c})");
                Rational rational = new Rational(-c, a);
                Console.WriteLine($"x^2 = {rational.ToString()}");
                if((-c/a)>0)
                {
                    double result = Math.Sqrt(-c*1.0 / a);
                    if(result == (int)result)
                    {
                        Console.WriteLine($"There is two solutions to this equation: x1 = {result} and x2 = {-result}.");
                    }
                    else
                    {
                        Console.WriteLine($"There is two solutions to this equation: x1 = \u221A{rational.ToString()} ({result}) and x2 = -\u221A{rational.ToString()} ({-result}).");
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
                Console.WriteLine($"x = {-c}/{b}");
                Console.WriteLine($"There is one solution to this equation: x = {-c*1.0 / b}.");
            }
            else
            {
                Console.WriteLine($"D = \u221A{b}^2 - 4*{a}*{c}");
                Console.WriteLine($"D = \u221A{Math.Pow(b,2) - 4*a*c}");
                double d = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                if (d == (int)d)
                {
                    Console.WriteLine($"D = {d}");
                    Console.WriteLine($"x1 = (-{b} + {d})/2*{a}");
                    double x1 = (-b + d) / 2 * a;
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = (-{b} - {d})/2*{a}");
                    double x2 = (-b + d) / 2 * a;
                    Console.WriteLine($"x2 = {x2}");
                }
                else
                {
                    Console.WriteLine($"D = \u221A{Math.Pow(b, 2) + 4 * a * c}");
                    Console.WriteLine($"x1 = (-{b} + \u221A{Math.Pow(b, 2) - 4 * a * c})/2*{a}");
                    Console.WriteLine($"x2 = (-{b} - \u221A{Math.Pow(b, 2) - 4 * a * c})/2*{a}");
                }
                
            }
            
        }
    }
}
