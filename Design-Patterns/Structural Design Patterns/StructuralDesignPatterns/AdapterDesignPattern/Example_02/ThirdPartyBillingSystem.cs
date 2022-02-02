namespace AdapterDesignPattern.Example_02
{
    // The Adaptee contains some functionality that is required by the client.
    // But this interface is not compatible with the client code.
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
