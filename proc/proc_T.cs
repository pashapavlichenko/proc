using System;
using System.Data.Common;
using System.Xml.Serialization;

namespace ProcA
{
    public class Proc
    {

        public int Proc30(int k, int n)
        {
            return N(k, n);
        }

        public int N(int k, int n)
        {
            if (k - Math.Pow(10, n - 1) < 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    k /= 10;
                }
                if (k > 10)
                {
                    k %= 10;
                }
                return k;
            }
        }

        public double[] Proc32(int[] a)
        {
            double[] b = new double[2];
            for (int i = 0; i < 2; i++)
            {
                b[i] = Rad(a[i]);
            }
            return b;
        }

        public double Rad(int d)
        {
            return 2 * 3.14 * d / 360;
        }



        public double Proc34(double a)
        {
            a = F(a);
            return a;
        }

        public double F(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * F(n - 1);
            }
        }

        public void Proc36()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(Fib(a[i]));
            }
        }

        public int Fib(int n)
        {
            int f1 = 1, f2 = 1, res;

            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    res = f1;
                    f1 = f2;
                    f2 = res + f2;
                }
                return f2;
            }
        }

        public void Proc38()
        {

        }

        public double Power2(double a, int n)
        {

            if (n > 0)
            {
                return a * Power2(a, n - 1);
            }
            else if (n < 0)
            {
                double s = 1;
                for (int i = 0; i < Math.Abs(n); i++)
                {
                    s *= 1 / a;
                }
                return s;
            }
            else
            {
                return 1;
            }
        }


        public void Proc40()
        {
            int x = 5;
            int[] e = { 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine(Exp1(x, e[i]));
            }
        }

        public double Exp1(int x, int e)
        {
            double TheExp = Math.Pow(e, x);
            double s = 0, i = 0;
            while (s <= TheExp)
            {
                s += Math.Pow(x, i) / Fact(i);
                i++;
            }
            if (TheExp - (s - Math.Pow(x, i)) < TheExp - s)
            {
                return TheExp - (s - Math.Pow(x, i));
            }
            else
            {
                return TheExp - s;
            }
        }

        public void Proc42()
        {
            double x = 2, e = 4;
            Console.WriteLine(Cos1(x, e));
        }

        public double Cos1(double x, double e)
        {
            double TheCos = Math.Cos(x);
            double s = 0, i = 0, d = 1;
            while (s <= TheCos)
            {
                s += Math.Pow(x, i) / Fact(i) * d;
                i++;
                d *= -1;
            }
            if (TheCos - (s - Math.Pow(x, i)) < TheCos - s)
            {
                return TheCos - (s - Math.Pow(x, i));
            }
            else
            {
                return (TheCos - s) / 2;
            }
        }

        public void Proc24()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Even(a[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public bool Even(int k) => k % 2 == 0;

        public void Proc26()
        {
            double[] a = { 125, 25, 625, 34, 876 };
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPower5(a[i]))
                {
                    Console.WriteLine("Yes ");
                }
                else
                {
                    Console.WriteLine("No ");
                }
            }
        }

        public bool IsPower5(double k)
        {
            double i = 0;
            while (i < k / 2 || k != Math.Pow(5, i))
            {
                i++;
            }
            return Math.Pow(5, i) == k;
        }

    }
}