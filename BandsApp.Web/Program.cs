namespace BandsApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //app.MapGet("/", () => "Hello World!");//test Niklas Test Sarbast //Test Astrid
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllers();
            app.UseStaticFiles();
            app.Run();
        }
    }
}
