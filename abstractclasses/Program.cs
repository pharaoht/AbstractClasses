using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //README If we create "BaseEmployee" class concrete (NON abstract) class, there is nothing stopping us from creating an instance of "BaseEmploye"
            //class. We only have two types of employees in our organization- Contract and FullTime. The developers should only be able to instantiate 
            //ContractEmployee & FullTime classes and not BaseEmployee class. 


            FullTimeEmployee fte = new FullTimeEmployee();
          fte.Id = 1023;
          fte.FirstName = "Mark";
          fte.LastName = "Sul";
          fte.AnnualSalary = 60000;

          ContractEmployee cte = new ContractEmployee();
          cte.Id = 1234;
          cte.FirstName = "Kyle";
          cte.LastName = "Mile";
          cte.HourlyPay = 23;
          cte.HoursWorked = 50;

          Console.WriteLine(fte);
          Console.WriteLine(fte.GetMonthlySalary());
          Console.WriteLine(cte.GetMonthlySalary());


        }

    }
}
