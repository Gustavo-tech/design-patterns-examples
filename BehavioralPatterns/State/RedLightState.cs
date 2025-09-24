namespace State;

internal class RedLightState : ITrafficLightState
{
    public void HandleRequest(TrafficLightContext context)
    {
        Console.WriteLine("Red Light: Cars must stop.");
        context.CurrentState = new GreenLightState();
    }
}