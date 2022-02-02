using IoC_Container_Demo.Refactored.Contracts;

namespace IoC_Container_Demo.Refactored;

public class CustomerDataAccess : IDataAccess
{
    public CustomerDataAccess()
    {

    }

    public string GetCustomerName(int id)
    {
        // get the customer name from the db in real application
        return "Dummy Customer Name";
    }
}
