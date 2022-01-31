namespace EmployeeManagementSystem.Non_Violated
{
    using System;
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("CEO has no manager");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance");
        }

        public void FireSomeOne()
        {
            Console.WriteLine("You're Fired");
        }
    }
}
