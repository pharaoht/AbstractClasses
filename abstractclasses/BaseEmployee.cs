using System;

namespace AbstractClasses
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string GetFullName()
        {
            return FirstName + "" + LastName;
        }

        public abstract int GetMonthlySalary(); //made it abstract to force all derived types implementation to salary
    }
}

