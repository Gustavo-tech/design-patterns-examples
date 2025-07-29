using Prototype.Models;
using Prototype.Models.Abstractions;

WarRobot warRobot = new("Sniper");
FlyerRobot flyerRobot = new(300);
List<Robot> robots = [warRobot, flyerRobot];

foreach (Robot robot in robots)
{
    Robot clonedRobot = robot.Clone(robot);
    Console.WriteLine($"Original: {robot}");
    Console.WriteLine($"Cloned: {clonedRobot}");
    Console.WriteLine($"They are equal: {robot == clonedRobot}");
    Console.WriteLine();
}