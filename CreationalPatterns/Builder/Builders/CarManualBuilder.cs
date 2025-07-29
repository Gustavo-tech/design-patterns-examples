using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders;

internal class CarManualBuilder : IBuilder
{
    private Manual _manual = new();

    public void Reset()
    {
        _manual = new();
    }

    public void SetEngine(string engine)
    {
        _manual.Engine = engine;
    }

    public void SetGPS(bool gps)
    {
        _manual.GPS = gps;
    }

    public void SetSeats(int seats)
    {
        _manual.Seats = seats;
    }

    public void SetTripComputer(bool tripComputer)
    {
        _manual.TripComputer = tripComputer;
    }

    public Manual GetResult()
    {
        Manual result = _manual;
        Reset();
        return result;
    }
}
