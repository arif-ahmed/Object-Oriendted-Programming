namespace EmployeeManagementSystem.Non_Violated
{
    public abstract class BaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public abstract void CalculatePerHourRate(int rank);
    }
}
