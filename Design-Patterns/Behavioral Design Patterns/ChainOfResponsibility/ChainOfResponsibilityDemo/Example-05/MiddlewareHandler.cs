namespace ChainOfResponsibilityDemo.Example_05;
public class MiddlewareHandler
{
    private readonly Func<string, Func<Task>, Task> _middleware;
    private MiddlewareHandler? _next;

    public MiddlewareHandler(Func<string, Func<Task>, Task> middleware)
    {
        _middleware = middleware;
    }

    public MiddlewareHandler SetNext(MiddlewareHandler next)
    {
        _next = next;
        return this; // Allow chaining
    }

    public async Task Invoke(string request)
    {
        await _middleware(request, async () =>
        {
            if (_next != null)
            {
                await _next.Invoke(request);
            }
        });
    }
}
