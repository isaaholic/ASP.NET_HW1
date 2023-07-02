namespace WebApplication1.Middlewares;

public class LoginMiddleware
{
    private RequestDelegate? _next;

    public LoginMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("Login started");
        await _next?.Invoke(context);
        Console.WriteLine("Login ended");
    }
}
