namespace Builder.Models;

internal class Manual : CarBase
{
    public Manual()
    {
    }

    public Manual(int seats, string engine, bool tripComputer, bool gPS)
        : base(seats, engine, tripComputer, gPS)
    {
    }

    public override string ToString()
    {
        return "Manual with " +
               $"{Seats} seats, Engine: {Engine}, Trip Computer: {TripComputer}, GPS: {GPS}";
    }
}
