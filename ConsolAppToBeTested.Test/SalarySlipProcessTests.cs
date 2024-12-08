namespace ConsolAppToBeTested.Test
{
    public class SalarySlipProcessTests
    {
        [Fact]
        public void CalculateTotalSalary_GivingTheEmployee_ReturnTheTotalSalary()
        {
           Employee employee = new Employee() {Id=1, Name="Mahmoud",Address="Bajour",Salary=100};
            SalarySlipProcessor salarySlipProcessor = new SalarySlipProcessor();
            var actual = salarySlipProcessor.CalculateTotalSalary(employee);
            var expected = 110m;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateTotalSalary_GivingTheEmployeeAsNull_ReturnTheTotalSalary()
        {
           Employee employee = null;
            SalarySlipProcessor salarySlipProcessor = new SalarySlipProcessor(null);
            Func<Employee, decimal> func = (e) => salarySlipProcessor.CalculateTotalSalary(employee);
            Assert.Throws<ArgumentNullException>(() => func(employee));
        } 

        [Fact]
        public void CalculateTotalSalary_IfTheEmployeeInServiceZoneDangerOn_ReturnTheTotalSalary()
        {
           Employee employee = new Employee() {Salary=100m, serviceZone=new ServiceZone() { IsDanger=true} };

            SalarySlipProcessor salarySlipProcessor = new SalarySlipProcessor(null);
           
           var actual=  salarySlipProcessor.CalculateTotalSalary(employee);
           var expected = 120m;
            Assert.Equal(expected, actual);

        }
    }
}