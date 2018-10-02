using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public TwoDShape(double w, double h)
        {
            pri_width = w;
            pri_height = h;
        }

        public double Width
        {
            get
            {
                return pri_width;
            }
            set
            {
                pri_width = value;
            }
        }

        public double Height
        {
            get
            {
                return pri_height;
            }
            set
            {
                pri_height = value;
            }
        }
    }
    class Triangle : TwoDShape
    {
        private string Style;
        public Triangle(double w, double h, string S) : base(w, h)
        {
            Style = S;
        }

        public void Calculate()
        {
            double T = Width * Height;

            Console.WriteLine(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle ob = new Triangle(8.0, 12.0, "right");

            ob.Calculate();
            Console.ReadLine();
        }
    }
}
