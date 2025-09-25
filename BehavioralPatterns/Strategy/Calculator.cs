namespace Strategy;
internal class Calculator
{
    private ICalculationStrategy _strategy;

    public Calculator(ICalculationStrategy strategy)
    {
        _strategy = strategy;
    }

    public int ExecuteCalculation(int value1, int value2)
    {
        return _strategy.Calculate(value1, value2);
    }
}
