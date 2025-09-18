namespace Observer;

internal class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = [];
    private float _temperature;
    private float _humidity;

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        _observers.ForEach(observer => observer.Update(_temperature, _humidity));
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetMeasurements(float temperature, float humidity)
    {
        _temperature = temperature;
        _humidity = humidity;
        NotifyObservers();
    }
}
