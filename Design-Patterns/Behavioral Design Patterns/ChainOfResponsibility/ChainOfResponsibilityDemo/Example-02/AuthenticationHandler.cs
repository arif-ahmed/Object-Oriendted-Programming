namespace ChainOfResponsibilityDemo.Example_02
{
    public class AuthenticationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authentication handler processing request");
        }
    }
}
