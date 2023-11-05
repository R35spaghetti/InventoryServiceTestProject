namespace InventoryServiceTestProject.Sut;

public record Product
{
    private int _id;
    private int _amount;
    private string? _name;

    internal int Id
    {
        get => _id;
        set => _id = value;
    }

    internal int Amount
    {
        get => _amount;
        set => _amount = value;
    }

    internal string Name
    {
        
        get => _name;
        set => _name = value;
    }

    public Product(int id, int amount, string name)
    {
        Id = id;
        Amount = amount;
        Name = name;
    }
}


