namespace ToDoApp5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute("default", "{controller=Todo}/{action=Index}");
            app.Run();
        }
    }
}
