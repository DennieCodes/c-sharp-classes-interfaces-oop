namespace CSharpDotNetTutorial.DependencyInversionPrinciple;

public class Relationships
{
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        this.relations.Add((parent, Relationship.Parent, child));
        this.relations.Add((child, Relationship.Child, parent));
    }

    public List<(Person, Relationship, Person)> Relations()
    {
        return this.relations;
    }
}
