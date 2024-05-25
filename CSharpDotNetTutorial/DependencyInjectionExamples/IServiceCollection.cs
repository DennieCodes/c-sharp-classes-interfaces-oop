namespace CSharpDotNetTutorial.DependencyInjectionExamples;

public interface IServiceCollection
{
    void AddDbContext<ApplicationDbContext>();
    void AddScoped<IProductService, ProductService>();
}
