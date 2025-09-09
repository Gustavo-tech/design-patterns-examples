namespace Mediator;
internal class AirportControlTower : IAirTrafficControlTower
{
    public void RequestLanding(IAirplane airplane)
    {
        airplane.NotifyAirTrafficControl("Requesting takeoff clearance");
    }

    public void RequestTakeOff(IAirplane airplane)
    {
        airplane.NotifyAirTrafficControl("Requesting landing clearance");
    }
}
