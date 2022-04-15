namespace DP.Builder.Exemple02;

public class Product
{
    private readonly LinkedList<string> _parts;

    public Product()
    {
        _parts = new LinkedList<string>();
    }

    public void Add(string part)
    {
        // adding parts
        _parts.AddLast(part);
    }

    public void Show()
    {
        Console.WriteLine("\nProduct Completed as below:");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }

}