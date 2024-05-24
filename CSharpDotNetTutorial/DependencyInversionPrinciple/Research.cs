namespace CSharpDotNetTutorial.DependencyInversionPrinciple
{
    public class Research
    {

        public Research(Relationships relationships)
        {

        }

        public void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Mary" };
            var child2 = new Person { Name = "Chris" };

        }
    }
}
