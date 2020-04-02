namespace EmployeeManagementSystem
{
    using System;
    public class EmployeeManagementSystemDemo
    {
        public void Violated_Code()
        {
            Violated.Manager accountingVIP = new Violated.Manager();
            accountingVIP.FirstName = "Emma";
            accountingVIP.LastName = "Stone";
            accountingVIP.CalculatePerHourRate(4);

            Violated.Employee emp = new Violated.Employee();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVIP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");
            Console.ReadLine();

            emp = accountingVIP;
            emp.CalculatePerHourRate(4);
        }
    }
}
