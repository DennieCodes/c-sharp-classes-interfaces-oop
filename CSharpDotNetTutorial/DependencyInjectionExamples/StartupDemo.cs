namespace CSharpDotNetTutorial.DependencyInjectionExamples;

public class StartupDemo
{
    // For IServiceCollection you would use Microsoft.Extensions.DependencyInjection.Abstractions
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<IProductService, ProductService>();
    }
}
