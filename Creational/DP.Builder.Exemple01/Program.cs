namespace DP.Builder.Exemple01;

class Program
{
    static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ConcreteBuilder();

        director.Builder = builder;
        
        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        Console.WriteLine("Standard full featured product");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        // can be used without A director
        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartB();
        Console.WriteLine(builder.GetProduct().ListParts());
    }
}