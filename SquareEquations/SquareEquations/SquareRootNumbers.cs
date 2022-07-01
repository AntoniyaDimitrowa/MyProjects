using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquations
{
    internal class SquareRootNumbers
    {
        public int numOutsideTheRoot = 0;
        public int numInsideTheRoot = 0;

        public SquareRootNumbers(int numInsideTheRoot)
        {
            this.numOutsideTheRoot = 1;
            this.numInsideTheRoot = numInsideTheRoot;
        }

        public override string ToString()
        {
            if(numInsideTheRoot == 1)
            {
                return $"{numOutsideTheRoot}";
            }
            else if (numOutsideTheRoot == 1)
            {
                return $"\u221A{numInsideTheRoot}";
            }
            else
            {
                return $"{numOutsideTheRoot}*\u221A{numInsideTheRoot}";
            }

        }

        public bool IsCorrect()
        {
            if(numInsideTheRoot < 0)
            {
                return false;
            }
            else return true;
        }

        public void FindingNumOutsideTheRoot()
        {
            if (Math.Sqrt(numInsideTheRoot) == (int)(Math.Sqrt(numInsideTheRoot)))
            {
                numOutsideTheRoot = (int)Math.Sqrt(numInsideTheRoot);
                numInsideTheRoot = 1;
            }
            else
            {
                List<int> divisors = new List<int>();
                while (numInsideTheRoot != 1)
                {
                    for (int i = 2; i <= numInsideTheRoot; i++)
                    {
                        if (numInsideTheRoot % i == 0)
                        {
                            divisors.Add(i);
                            numInsideTheRoot = numInsideTheRoot / i; ;
                            break;
                        }
                    }
                }
                if (divisors.Count == 1)
                {
                    numInsideTheRoot = divisors[0];
                    numOutsideTheRoot = 1;
                }
                else
                {
                    for (int i = 0; i < divisors.Count; i++)
                    {
                        if (i == divisors.Count - 1)
                        {
                            numInsideTheRoot = numInsideTheRoot * divisors[i];
                        }
                        else if (divisors[i] == divisors[i + 1])
                        {
                            numOutsideTheRoot = numOutsideTheRoot * divisors[i];
                            divisors.RemoveAt(i);
                            divisors.RemoveAt(i + 1);
                            i--;
                        }
                        else
                        {
                            numInsideTheRoot = numInsideTheRoot * divisors[i];
                        }
                    }
                }
            }
        }
    }
}
