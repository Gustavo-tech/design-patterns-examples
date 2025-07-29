using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders;

internal class CarBuilder : IBuilder
{
    private Car _car = new();

    public Car Build()
    {
        Car result = _car;
        Reset();
        return result;
    }

    public void Reset()
    {
        _car = new();
    }

    public void SetEngine(string engine)
    {
        _car.Engine = engine;
    }

    public void SetGPS(bool gps)
    {
        _car.GPS = gps;
    }

    public void SetSeats(int seats)
    {
        _car.Seats = seats;
    }

    public void SetTripComputer(bool tripComputer)
    {
        _car.TripComputer = tripComputer;
    }
}
