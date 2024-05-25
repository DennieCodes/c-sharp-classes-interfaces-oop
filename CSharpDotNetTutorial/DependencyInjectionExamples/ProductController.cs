namespace CSharpDotNetTutorial.DependencyInjectionExamples;

public class ProductController
{
    private IProductService productService;

    public ProductController(IProductService productService)
    {
        this.productService = productService;
    }

    public void Index()
    {
        var products = this.productService.GetProducts();
    }
}
