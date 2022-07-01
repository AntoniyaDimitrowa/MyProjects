using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquations
{
    internal class Rational
    {
        public int num = 0;
        public int denum = 1;

        public Rational(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }
        public override string ToString()
        {
            if (denum == 1)
            {
                return $"{num}";
            }
            else
            {
                return $"{num}/{denum}";
            }
        }
        public void NOD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                int c = a;
                a = b;
                b = c;
            }
            int ost = 0;
            while (b != 0)
            {
                ost = a % b;
                a = b;
                b = ost;
            }
            int nod = a;
        }
    }
}
