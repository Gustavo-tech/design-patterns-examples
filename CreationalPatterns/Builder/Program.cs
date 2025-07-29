using Builder.Builders;
using Builder.Models;

Director director = new();
CarBuilder carBuilder = new();
CarManualBuilder manualBuilder = new();

director.ConstructSportsCar(carBuilder);
director.ConstructSportsCar(manualBuilder);

Car sportsCar = carBuilder.Build();
Manual sportsCarManual = manualBuilder.GetResult();

Console.WriteLine("Result of sport car:");
Console.WriteLine(sportsCar);
Console.WriteLine(sportsCarManual);

director.ConstructSuv(carBuilder);
director.ConstructSuv(manualBuilder);

Car suv = carBuilder.Build();
Manual suvManual = manualBuilder.GetResult();

Console.WriteLine();
Console.WriteLine("Result of suv car");
Console.WriteLine(suv);
Console.WriteLine(suvManual);