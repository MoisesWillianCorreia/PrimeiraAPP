using Microsoft.AspNetCore.HTTP;

public class meumiddler
{
    private readonly RequestDeLegate_next ;

    public meumiddler (RequestDeLegate next)
    {
        _next = next ;
    }

    public async Task InvokeAsync (HTTPContext context)
    {
        console.writeline("/n/r ------ Antes --------/n/r");

        await _next(context);

        console.writeline("/n/r ------ Depois --------/n/r");

    }

}

public static class meumiddlerExtension
{
    public static IApplicationBuilder UseMiddleware (this IApplicationBuilder Builder)
    {
        return Builder.UseMiddleware<>();
    }
}