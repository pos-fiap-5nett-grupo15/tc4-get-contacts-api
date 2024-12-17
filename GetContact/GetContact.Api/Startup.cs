
using ContactsManagement.Application.DTOs.Validations;
using CreateContact.Infrastructure.Services.Contact;
using CreateContact.Infrastructure.UnitOfWork;
using FluentValidation;
using GetContacts.Application.DTOs.Contacts.GetContacts;
using GetContacts.Application.Handlers.Contacts.GetContacts;
using Prometheus;
using TechChallenge3.Infrastructure.Crypto;
using TechChallenge3.Infrastructure.DefaultStartup;
using TechChallenge3.Infrastructure.Middlewares;
using TechChallenge3.Infrastructure.Settings;
using TechChallenge3.Infrastructure.UnitOfWork;

internal class Startup : BaseStartup
{

    public Startup(ConfigurationManager configuration) : base(configuration)
    { }

    public void ConfigureServiceApp(IServiceCollection services)
    {
        base.ConfigureService(services);


        // Logging
        services.AddLogging();

        services.AddScoped<IGetContactUnitOfWork, GetContactUnitOfWork>();
        services.AddScoped<IContactService, ContactService>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetContactByIdHandler).Assembly));
        services.AddTransient<IValidator<GetContactsByIdRequest>, GetContactByIdValidation>();


    }

    internal void ConfigureApp(IApplicationBuilder app, IWebHostEnvironment environment)
    {
        base.Configure(app, environment);
        app.UseMiddleware<RequestCounterMiddleware>();
        app.UseMetricServer();
    }
}