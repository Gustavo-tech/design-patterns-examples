namespace Builder.Models;

internal class Car : CarBase
{
    public Car()
    {
    }

    public Car(int seats, string engine, bool tripComputer, bool gPS)
        : base(seats, engine, tripComputer, gPS)
    {
    }

    public override string ToString()
    {
        return $"Car with {Seats} seats, Engine: {Engine}, Trip Computer: {TripComputer}, GPS: {GPS}";
    }
}
