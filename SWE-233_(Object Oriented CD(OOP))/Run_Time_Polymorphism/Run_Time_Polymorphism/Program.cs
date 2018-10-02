using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_Polymorphism
{
    class Shape
    {
        public virtual void Draw()
        {

        }
    }
    class Ractangel : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Ractangle Drawn ");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle Drawn ");
        }
    }
    class Trangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Trangle Drawn ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Testing Polymorphism */

            Shape[] s = new Shape[3];

            /* Polymorphism Object */
            /* creating Array with Different type of Objects */

            s[0] = new Circle();
            s[1] = new Ractangel();
            s[2] = new Trangle();

            Console.WriteLine("\n\n Runtime polymorphism test \n\n");

            for (int i = 0; i < 3; i++)
            {
                s[i].Draw();
            }
            Console.ReadKey();
        }
    }
}
