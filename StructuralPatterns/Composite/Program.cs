using Composite;

Employee Thiago = new() { Id = 1, Name = "Thiago" };
Employee Gabriel = new() { Id = 2, Name = "Gabriel" };
Employee Jones = new() { Id = 3, Name = "Jones" };

Thiago.AddSubordinate(Gabriel);
Thiago.AddSubordinate(Jones);

Employee Barbara = new() { Id = 4, Name = "Barbara" };
Employee Andre = new() { Id = 5, Name = "André" };

Gabriel.AddSubordinate(Barbara);
Gabriel.AddSubordinate(Andre);

Employee Cesar = new() { Id = 6, Name = "Cesar" };
Employee Igor = new() { Id = 7, Name = "Igor" };

Contractor Gisnando = new() { Id = 8, Name = "Gisnando" };
Contractor Gerlandio = new() { Id = 9, Name = "Gerlandio" };

Jones.AddSubordinate(Cesar);
Jones.AddSubordinate(Igor);
Jones.AddSubordinate(Gisnando);
Jones.AddSubordinate(Gerlandio);

Console.WriteLine($"Id={Thiago.Id}, Name={Thiago.Name}");

foreach (Employee manager in Thiago)
{
    Console.WriteLine($"\n Id={manager.Id}, Name={manager.Name}");
    foreach (var employee in manager)
    {
        Console.WriteLine($" \t Id={employee.Id}, Name={employee.Name}");
    }
}
