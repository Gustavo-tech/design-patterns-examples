namespace Mediator;

internal interface IAirplane
{
    void RequestTakeOff();
    void RequestLanding();
    void NotifyAirTrafficControl(string message);
}
