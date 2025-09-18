using Observer;

WeatherStation weatherStation = new();

// Create two displays and register them as observers
WeatherDisplay display1 = new();
WeatherDisplay display2 = new();

weatherStation.AddObserver(display1);
weatherStation.AddObserver(display2);// Simulate changes in weather data

weatherStation.SetMeasurements(25.5f, 65.0f);
weatherStation.SetMeasurements(27.3f, 70.0f);