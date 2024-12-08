internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var startup = new Startup(builder.Configuration);
        startup.ConfigureServiceApp(builder.Services);



        var app = builder.Build();
    
        startup.ConfigureApp(app,app.Environment);

        app.Run();
    }
}