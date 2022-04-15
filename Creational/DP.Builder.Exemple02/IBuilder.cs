namespace DP.Builder.Exemple02;

public interface IBuilder
{
    void StartUpOperations();
    void BuildBody();
    void InsertWheels();
    void AddHeadLights();
    void EndOperations();
    Product GetVehicle();
}