namespace ConsolAppToBeTested
{
    public class SalarySlipProcessor 
    {
        private readonly IServiceZone serviceZone;

        public SalarySlipProcessor(IServiceZone serviceZone)
        {
            this.serviceZone = serviceZone;
        }


        public decimal CalculateTotalSalary(Employee employee)
        {
            if (employee == null)
                 throw new ArgumentNullException(nameof(employee));

            if (employee.serviceZone?.IsDanger == true)
            {
                return employee.Salary = employee.Salary * (1 + employee.Bonus*2);
            }


            return employee.Salary= employee.Salary*(1+ employee.Bonus);
        }
    }

}
