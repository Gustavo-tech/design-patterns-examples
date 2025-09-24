namespace State;

internal class GreenLightState : ITrafficLightState
{

    public void HandleRequest(TrafficLightContext context)
    {
        Console.WriteLine("Green Light: Cars can go.");
        context.CurrentState = new YellowLightState();
    }
}