namespace Observer;

internal interface IObserver
{
    void Update(float temperature, float humidity);
}
