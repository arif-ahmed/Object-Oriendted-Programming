namespace EmployeeBonusCalculation.Violated
{
    using System;
    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        {
        }

        public ContractEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
