using IoC_Container_Demo.Refactored.Contracts;

namespace IoC_Container_Demo.Refactored;

public class CustomerBusinessLogic
{
    private readonly IDataAccess _dataAccess;

    public CustomerBusinessLogic(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public string ProcessCustomerData(int id)
    {
        return _dataAccess.GetCustomerName(id);
    }
}