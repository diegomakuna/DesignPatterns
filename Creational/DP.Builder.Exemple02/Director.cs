namespace DP.Builder.Exemple02;

public class Director
{
     IBuilder _builder;

    public void Construct(IBuilder builder)
    {
        _builder = builder;
        _builder.StartUpOperations();
        _builder.BuildBody();
        _builder.InsertWheels();
        _builder.AddHeadLights();
        _builder.EndOperations();
    }
}