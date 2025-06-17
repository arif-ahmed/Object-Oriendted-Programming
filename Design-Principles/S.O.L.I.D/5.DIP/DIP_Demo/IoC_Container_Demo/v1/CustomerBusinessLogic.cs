namespace IoC_Container_Demo.v1;

public class CustomerBusinessLogic
{
    CustomerDataAccess _dataAccess;

    public CustomerBusinessLogic()
    {
        _dataAccess = new CustomerDataAccess();
    }

    public string ProcessCustomerData(int id)
    {
        return _dataAccess.GetCustomerName(id);
    }
}