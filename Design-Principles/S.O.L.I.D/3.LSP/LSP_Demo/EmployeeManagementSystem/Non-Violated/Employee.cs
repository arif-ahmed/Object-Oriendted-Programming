namespace EmployeeManagementSystem.Non_Violated
{
    using Contracts;
    public class Employee : BaseEmployee, IManaged
    {
        public Employee Manager { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}
