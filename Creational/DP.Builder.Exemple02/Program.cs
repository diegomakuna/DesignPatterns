// See https://aka.ms/new-console-template for more information

namespace DP.Builder.Exemple02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Builder Pattern Demo***");
        Director director = new Director();
        IBuilder ford = new Car("Ford");
        IBuilder honda = new MotorCycle("Honda");
        
        director.Construct(ford);
        Product car = ford.GetVehicle();
        car.Show();
        
        director.Construct(honda);
        Product motorcycle = honda.GetVehicle();
        motorcycle.Show();
    }
}