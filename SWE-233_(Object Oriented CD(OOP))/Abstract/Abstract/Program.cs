using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
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
        public FullTimeEmployee(int I, string FN, string LN, double AS)
        {
            ID = I;
            FirstName = FN;
            LastName = LN;
            AnnualSalary = AS;
        }

        public override void GetFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("Annual Salary is: " + AnnualSalary / 12);
        }
    }

    class ContractEmployee : BaseEmployee
    {
        public double Hourlypay;
        public int TotalHour;
        public ContractEmployee(int I, string FN, string LN, double HP, int TH)
        {
            ID = I;
            FirstName = FN;
            LastName = LN;
            Hourlypay = HP;
            TotalHour = TH;
        }

        public override void GetFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }

        public override void GetMonthlySalary()
        {
            Console.WriteLine("Annual Salary is: " + Hourlypay * TotalHour);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee ob1 = new FullTimeEmployee(161, "Rony ", "Mahmud", 100000);
            ob1.GetFullName();
            ob1.GetMonthlySalary();

            ContractEmployee ob2 = new ContractEmployee(171, "Muta ", "Shuvo", 500, 8);
            ob2.GetFullName();
            ob2.GetMonthlySalary();

            Console.ReadLine();
        }
    }
}
