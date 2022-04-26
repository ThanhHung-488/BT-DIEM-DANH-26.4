using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a226 = Int32.Parse(Console.ReadLine());
            double b226 = Int32.Parse(Console.ReadLine());
            double c226 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a226, b226, c226);

            double delta = pt.delta(a226, b226, c226);
            int check = pt.nghiem(delta);
            if (check < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (check == 0)
            {
                double x = -b226 / (2 * a226);
                Console.WriteLine("Phuong trinh co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b226 - Math.Sqrt(delta)) / (2 * a226);
                double x2 = (-b226 + Math.Sqrt(delta)) / (2 * a226);

                Console.WriteLine("Phuong trinh co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a226;
        private double b226;
        private double c226;

        public ptb2()
        {
        }

        public ptb2(double a226, double b226, double c226)
        {
            A = a226;
            B = b226;
            C = c226;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a226, double b226, double c226)
        {
            return b226 * b226 - 4 * a226 * c226;
        }

        public int nghiem(double delta)
        {
            if (delta < 0)
            {
                return -1;
            }
            else if (delta == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}