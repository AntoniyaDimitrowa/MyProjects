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

            //Rational ra = new Rational(3, -2);
            //Console.WriteLine(ra.ToString());
            //ra.NOD(ra.num,ra.denum);
            //Console.WriteLine(ra.ToString());

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
                Rational rational = new Rational(-b, a);
                rational.NOD(rational.num,rational.denum);
                Console.WriteLine($"There is two solutions to this equation: x1 = 0 and x2 = {rational.ToString()}.");
            }
            else if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine($"{a}x^2 + {c} = 0");
                Console.WriteLine($"{a}x^2 = -({c})");
                Rational rational = new Rational(-c, a);
                rational.NOD(rational.num, rational.denum);
                Console.WriteLine($"x^2 = {rational.ToString()}");

                if((-c*1.0/a)>0)
                {
                    Console.WriteLine($"x = ± \u221A({rational.ToString()})");
                    SquareRootNumbers num = new SquareRootNumbers(rational.num);
                    num.FindingNumOutsideTheRoot();
                    //Console.WriteLine(num.ToString());
                    SquareRootNumbers denum = new SquareRootNumbers(rational.denum);
                    denum.FindingNumOutsideTheRoot();
                    //Console.WriteLine(denum.ToString());

                    Console.WriteLine($"x = ± \u00B1{num.ToString()}/{denum.ToString()}");
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
                Rational rational = new Rational(-c, b);
                rational.NOD(rational.num, rational.denum);
                Console.WriteLine($"x = {rational.ToString()}");
            }
            else
            {
                Console.WriteLine($"D = {b}^2 - 4*{a}*{c}");
                Console.WriteLine($"D = {Math.Pow(b,2) - 4*a*c}");
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine($"D = {d} < 0");
                    Console.WriteLine($"There is no solution to this equation.");
                }
                else if (d == 0)
                {
                    Console.WriteLine($"D = {d}");
                    SquareRootNumbers first = new SquareRootNumbers(a);
                    first.FindingNumOutsideTheRoot();
                    SquareRootNumbers second = new SquareRootNumbers(c);
                    second.FindingNumOutsideTheRoot();
                    string result;
                    if(first.ToString() == "1")
                    {
                        result = $"{second.ToString()}";
                    }
                    else
                    {
                        result = $"{second.ToString()}/{first.ToString()}";
                    }
                    if (b>0)
                    {
                        Console.WriteLine($"({first.ToString()}x + {second.ToString()})^2 = 0");
                        Console.WriteLine($"x = -({result})");
                    }
                    else
                    {
                        Console.WriteLine($"({first.ToString()}x - {second.ToString()})^2 = 0");
                        Console.WriteLine($"x = {result}");
                    }
                }     
                else
                {
                    if (d == (int)d)
                    {
                        Console.WriteLine($"D = {d}");
                        Console.WriteLine($"x1 = (-{b} + {Math.Sqrt(d)})/2*{a}");
                        double x1 = (-b + d) / 2 * a;
                        Console.WriteLine($"x1 = {x1}");
                        Console.WriteLine($"x2 = (-{b} - {Math.Sqrt(d)})/2*{a}");
                        double x2 = (-b + d) / 2 * a;
                        Console.WriteLine($"x2 = {x2}");
                    }
                    else
                    {
                        Console.WriteLine($"D = \u221A{Math.Pow(b, 2) + 4 * a * c}");
                        Console.WriteLine($"x1 = (-{b} + \u221A{d})/2*{a}");
                        Console.WriteLine($"x2 = (-{b} - \u221A{d})/2*{a}");
                    }
                }
            }
            
        }
    }
}
