using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomer
    {
        void Print(Manager ob);
    }

    interface I2
    {
        void I2Method(Manager ob);
    }

    class Customer : ICustomer , I2
    {
        public void Print(Manager ob)
        {
            Console.WriteLine("Interface print method");
            Console.WriteLine(ob.CustomerID);
        }

        public void I2Method(Manager ob)
        {
            Console.WriteLine("I2Method");
            Console.WriteLine(ob.CustomerID);
        }
    }
    class Manager
    {
        public int CustomerID;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            Manager ob1 = new Manager();
            ob1.CustomerID = 161;
            C1.Print(ob1);
            C1.I2Method(ob1);

            Console.ReadLine();
        }
    }
}
