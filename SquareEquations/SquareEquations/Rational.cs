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
            int num = a;
            int denum = b;
            if (num < denum)
            {
                int c = num;
                num = denum;
                denum = c;
            }
            int ost = 0;
            while (denum != 0)
            {
                ost = num % denum;
                num = denum;
                denum = ost;
            }
            int nod = num;
            
            if(b/nod < 0)
            {
                this.num = -a / nod;
                this.denum = -b / nod;
            }
            else
            {
                this.num = a / nod;
                this.denum = b / nod;
            }
        }
    }
}
