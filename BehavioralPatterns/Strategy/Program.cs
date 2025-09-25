using Strategy;

Calculator calculator = new(new AdditionStrategy());
int result = calculator.ExecuteCalculation(5, 3);
Console.WriteLine(result);

Calculator calculator2 = new(new SubtractionStrategy());
int result2 = calculator2.ExecuteCalculation(5, 3);
Console.WriteLine(result2);