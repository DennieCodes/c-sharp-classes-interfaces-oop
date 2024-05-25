namespace CSharpDotNetTutorial.DependencyInjectionExamples;

public class ProductService : IProductService
{
    private ApplicationDbContext dbContext;

    public ProductService(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<Product> GetProducts()
    {
        return new List<Product>();
    }
}
