namespace EmployeeBonusCalculation.Violated
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            Id = id; 
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("Id : {0} Name : {1}", this.Id, this.Name);
        }
    }
}
