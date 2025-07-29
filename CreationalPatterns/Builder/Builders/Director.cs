using Builder.Builders.Interfaces;

namespace Builder.Builders;

internal class Director
{
    internal void ConstructSportsCar(IBuilder builder)
    {
        builder.SetSeats(2);
        builder.SetEngine("Sport engine");
        builder.SetTripComputer(false);
        builder.SetGPS(false);
    }

    internal void ConstructSuv(IBuilder builder)
    {
        builder.SetSeats(4);
        builder.SetEngine("Normal engine");
        builder.SetTripComputer(true);
        builder.SetGPS(true);
    }
}
