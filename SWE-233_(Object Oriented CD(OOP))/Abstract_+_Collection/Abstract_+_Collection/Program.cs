using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract___Collection
{
    abstract class BaseEmployee
    {
        public int ID;
        public string FirstName;
        public string LastName;

        public abstract void GetFullName();

        public abstract void GetMonthlySalary();
    }

    class FullTimeEmployee : BaseEmployee
    {
        public double AnnualSalary;

        public override void GetFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("AnnualSalary is: " + AnnualSalary / 12);
        }
    }

    class ContractEmployee : BaseEmployee
    {
        public double Hourlypay;
        public int TotalHour;

        public override void GetFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("AnnualSalary is: " + Hourlypay * TotalHour);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee ob1 = new FullTimeEmployee();
            FullTimeEmployee ob2 = new FullTimeEmployee();

            List<FullTimeEmployee> ob = new List<FullTimeEmployee>();
            ob.Add(ob1);
            ob.Add(ob2);

            foreach (FullTimeEmployee fm in ob)
            {
                fm.ID = Convert.ToInt32(Console.ReadLine());
                fm.FirstName = Console.ReadLine();
                fm.LastName = Console.ReadLine();
                fm.AnnualSalary = Convert.ToDouble(Console.ReadLine());

                fm.GetFullName();
                fm.GetMonthlySalary();
            }

            /*
            ob1.ID = 161;
            ob1.FirstName = "Rony ";
            ob1.LastName = "Mahmud";
            ob1.AnnualSalary = 100000;
            */

            ContractEmployee obj1 = new ContractEmployee();
            ContractEmployee obj2 = new ContractEmployee();

            List<ContractEmployee> obj = new List<ContractEmployee>();
            obj.Add(obj1);
            obj.Add(obj2);

            foreach (ContractEmployee cm in obj)
            {
                cm.ID = Convert.ToInt32(Console.ReadLine());
                cm.FirstName = Console.ReadLine();
                cm.LastName = Console.ReadLine();
                cm.Hourlypay = Convert.ToDouble(Console.ReadLine());
                cm.TotalHour = Convert.ToInt32(Console.ReadLine());

                cm.GetFullName();
                cm.GetMonthlySalary();
            }

            /*
            ob2.ID = 171;
            ob2.FirstName = "Muda ";
            ob2.LastName = "Kutta";
            ob2.Hourlypay = 500;
            ob2.TotalHour = 8;
            */

            Console.ReadLine();
        }
    }
}
