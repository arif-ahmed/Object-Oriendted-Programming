namespace MySimpleIOCContainer
{
    public interface IDependentOnTextRepository
    {
        //Method signature which is liable to inject/set dependency
        void SetDependency(IRepository repository);

    }
}