using CSharpDotNetTutorial.OpenClosedPrinciple;

namespace CSharpDotNetTutorial.OpenClosePrinciple
{
    public class Demo
    {
        public void Show()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            // The following commented out line showcases a violation of the open-closed principle because
            // the ProductFilter class requires modification to incorporate new types of filter.

            //var pf = new ProductFilter();
            //Console.WriteLine("Green products (old):");
            //foreach (var product in pf.FilterByColor(products, Color.Green))
            //{
            //    Console.WriteLine($" - {product.Name} is green");
            //}

            var br = new BetterFilter();

            foreach (var product in br.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {product.Name} is green");

            foreach (var product in br.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {product.Name} is large");

            foreach (var product in br.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
            {
                Console.WriteLine($" - {product.Name} is blue and large");
            }
        }
    }
}
