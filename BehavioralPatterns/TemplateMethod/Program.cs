using TemplateMethod;

Console.WriteLine("Making tea:");
BeverageMaker teaMaker = new TeaMaker();
teaMaker.MakeBeverage();

Console.WriteLine("\nMaking coffee:");
BeverageMaker coffeeMaker = new CoffeeMaker();
coffeeMaker.MakeBeverage();