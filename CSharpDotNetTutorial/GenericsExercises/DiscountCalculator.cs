namespace CSharpDotNetTutorial.GenericsExercises;

// Example with a constraint to a class
public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculateDiscount(TProduct product)
    {
        return product.Value;
    }
}

public class Product
{
    public float Value { get; set; }
}
