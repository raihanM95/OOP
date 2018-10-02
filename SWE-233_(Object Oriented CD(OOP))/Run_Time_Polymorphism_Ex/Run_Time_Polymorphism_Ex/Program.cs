using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_Polymorphism_Ex
{
    class Parent
    {
        public virtual void hello()
        {
            Console.WriteLine("A D Patel");
        }
    }
    class Child : Parent
    {
        public override void hello()
        {
            Console.WriteLine("R A Patel");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Child();
            obj.hello();

            Console.ReadLine();
        }
    }
}
