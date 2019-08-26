namespace AbstractClasses
{
    class ContractEmployee:BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int HoursWorked { get; set; }
        public override int GetMonthlySalary()
        {
            return HourlyPay * HoursWorked;
        }
    }
}