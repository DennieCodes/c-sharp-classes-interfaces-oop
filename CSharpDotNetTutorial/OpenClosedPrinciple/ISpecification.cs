namespace CSharpDotNetTutorial.OpenClosePrinciple;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}
