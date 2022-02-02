namespace MySimpleIOCContainer
{

    /// <summary>
    /// This is a class where we put our business logic.
    /// here we have SavePurchaseOrder method which is responsible for storing data
    /// But this class doesnt know where to store data. it just using implemention of IRepository to storing data
    /// </summary>
    public class PurchaseBl
    {
        private readonly IRepository _repository;
        public PurchaseBl(IRepository repository)
        {
            _repository = repository;
        }

        public string SavePurchaseOrder()
        {
            return _repository.Save();
        }
    }


    //public class PurchaseBl
    //{
    //    public IRepository Repository { get; set; }
  
    //    public string SavePurchaseOrder()
    //    {
    //        return Repository.Save();
    //    }
    //}

    //public class PurchaseBl :IDependentOnTextRepository
    //{
    //    private IRepository _repository;

    //    public string SavePurchaseOrder()
    //    {
    //        return _repository.Save();
    //    }

    //    public void SetDependency(IRepository repository)
    //    {
    //        _repository = repository;
    //    }
    //}

}
