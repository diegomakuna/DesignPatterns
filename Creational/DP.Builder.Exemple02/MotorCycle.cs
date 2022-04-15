namespace DP.Builder.Exemple02;

public class MotorCycle : IBuilder
{
    private string _brandName;
    private Product _product;

    public MotorCycle(string brandName)
    {
        _product = new Product();
        _brandName = brandName;
    }
    
    public void StartUpOperations()
    {
        // nothing in this case
    }

    public void BuildBody()
    {
        _product.Add("This is a body of a Motorcycle");
    }

    public void InsertWheels()
    {
        _product.Add("2 wheels are added");
    }

    public void AddHeadLights()
    {
        _product.Add("1 Headlights are added");
    }

    public void EndOperations()
    {
        // finishing up with brandname
        _product.Add($"Motorcycle model name {_brandName}");
    }

    public Product GetVehicle()
    {
        return _product;
    }
}