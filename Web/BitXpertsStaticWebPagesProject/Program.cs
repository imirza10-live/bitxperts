namespace BitXperts.Web.StaticWebPages;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        // Enable static file serving
        app.UseDefaultFiles();  // serves index.html automatically
        app.UseStaticFiles();

        // Fallback route (so "/" shows the index.html too)
        app.MapFallbackToFile("index.html");

        app.Run();
    }
}
