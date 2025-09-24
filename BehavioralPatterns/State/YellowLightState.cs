namespace State;

internal class YellowLightState : ITrafficLightState
{
    public void HandleRequest(TrafficLightContext context)
    {
        Console.WriteLine("Yellow Light: Cars should prepare to stop.");
        context.CurrentState = new RedLightState();
    }
}