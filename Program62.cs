using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    public interface IMeasurable
    {
        double Perimeter();
        double Area();
        void Show();
    }

    class Square : IMeasurable
    {
        protected float a;
        public Square(int b)
        {
            a = b;
        }
        public double Perimeter() {
            return 4 * a;
        }
        public double Area()
        {
            return a * a;
        }
        public void Show()
        {
            Console.WriteLine("a = " + a);
        }



    }
    class Program62
    {
        static void Main(string[] args)
        {
            IMeasurable[] a = new IMeasurable[3];
            a[0] = new Square(2);
            a[1] = new Square(5);
            a[2] = new Square(4);
            foreach (IMeasurable x in a)
            {
                x.Show();
                Console.WriteLine("Area is " + x.Area());
                Console.WriteLine("Perimeter is " + x.Perimeter());
                
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
