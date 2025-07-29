namespace Builder.Models;

internal abstract class CarBase
{
    public int Seats { get; set; }
    public string? Engine { get; set; }
    public bool TripComputer { get; set; }
    public bool GPS { get; set; }

    public CarBase()
    {
    }

    public CarBase(int seats, string engine, bool tripComputer, bool gPS)
    {
        Seats = seats;
        Engine = engine;
        TripComputer = tripComputer;
        GPS = gPS;
    }
}
