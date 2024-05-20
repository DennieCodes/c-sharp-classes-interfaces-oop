using System;
namespace CSharpDotNetTutorial;

public class Customer
{
    public int Id;
    public string? Name { get; set; }
    public readonly List<Order> Orders = new List<Order>();

    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
    }
}