using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compile_Time_Polymorphism
{
    class Program
    {
        int x, y, z;
        public Program()
        {
            x = y = z = 0;
        }

        public Program(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static Program operator +(Program obj1, Program obj2)
        {
            Program result = new Program();
            result.x = obj1.x + obj2.x;
            result.y = obj1.y + obj2.y;
            result.z = obj1.z + obj2.z;

            return result;
        }

        public static Program operator -(Program obj1, Program obj2)
        {
            Program result = new Program();
            result.x = obj1.x - obj2.x;
            result.y = obj1.y - obj2.y;
            result.z = obj1.z - obj2.z;

            return result;
        }

        public void show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
        static void Main(string[] args)
        {
            Program objA = new Program(1, 2, 3);

            Program objB = new Program(25, 22, 10);

            Program objC;

            Console.WriteLine("The value of objA: ");
            objA.show();
            Console.WriteLine();

            Console.WriteLine("The value of objB: ");
            objB.show();
            Console.WriteLine();

            objC = objA + objB;
            Console.WriteLine("Result of objA + objB");
            objC.show();
            Console.WriteLine();

            objC = objA + objB + objC;
            Console.WriteLine("Adding objA, objB, objC");
            objC.show();
            Console.WriteLine();

            objC = objC - objA;
            Console.WriteLine("Subtracting objC - objA");
            objC.show();
            Console.WriteLine();

            objC = objC - objB;
            Console.WriteLine("Subtracting objC - objB");
            objC.show();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
