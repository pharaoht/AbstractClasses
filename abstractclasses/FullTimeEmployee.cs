namespace AbstractClasses
{
    class FullTimeEmployee:BaseEmployee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }

        
    }
}