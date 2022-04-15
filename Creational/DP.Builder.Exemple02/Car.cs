using System.Net.Http.Headers;

namespace DP.Builder.Exemple02;

public class Car : IBuilder
{
    private string _brandName;
    private Product _product;

    public Car(string brand)
    {
        _product = new Product();
        _brandName = brand;
    }
    public void StartUpOperations()
    {
        // start com brandname
        _product.Add($"Car Model Name {this._brandName}");
    }

    public void BuildBody()
    {
       _product.Add("This is a body of car");
    }

    public void InsertWheels()
    {
        _product.Add("4 Wheels are added");
    }

    public void AddHeadLights()
    {
        _product.Add("2 headlights are added");
    }

    public void EndOperations()
    {
        // nothing in this case
    }

    public Product GetVehicle()
    {
        return _product;
    }
}