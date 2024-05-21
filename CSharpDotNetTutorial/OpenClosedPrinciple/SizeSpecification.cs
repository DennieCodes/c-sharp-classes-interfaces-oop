using CSharpDotNetTutorial.OpenClosePrinciple;

namespace CSharpDotNetTutorial.OpenClosedPrinciple;

public class SizeSpecification : ISpecification<Product>
{
    private Size size;

    public SizeSpecification(Size size)
    {
        this.size = size;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Size == size;
    }
}
