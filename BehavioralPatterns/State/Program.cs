using State;

TrafficLightContext trafficLight = new();

for (int i = 0; i < 6; i++)
{  // Change the light multiple times
    trafficLight.ChangeLight();
    Console.WriteLine();
}