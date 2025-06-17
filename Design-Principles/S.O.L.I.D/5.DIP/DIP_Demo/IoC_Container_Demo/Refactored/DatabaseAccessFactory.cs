using IoC_Container_Demo.Refactored.Contracts;
using System;
using System.Collections.Generic;
namespace IoC_Container_Demo.Refactored;
public class DatabaseAccessFactory
{
    public static IDataAccess GetDataAccess()
    {
        return new CustomerDataAccess();
    }
}
