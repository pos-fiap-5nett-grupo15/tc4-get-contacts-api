
using TechChallenge3.Infrastructure.DefaultStartup;

internal class Startup : BaseStartup
{
    private IConfiguration configuration;

    public Startup(ConfigurationManager configuration) : base(configuration)
    {
        this.configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        this.ConfigureService(services);
        //this.ConfigureUnitOfWork(services);

    }

    private void ConfigureUnitOfWork(IServiceCollection services)
    {
// services.AddScoped<IGetContactUnitOfWork, GetContactUnitOfWork>()
    }
}