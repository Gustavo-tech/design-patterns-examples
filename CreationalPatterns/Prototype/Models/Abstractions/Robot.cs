namespace Prototype.Models.Abstractions;

internal abstract class Robot
{
    internal int Legs { get; set; }
    internal int Arms { get; set; }
    internal int Heads { get; set; }
    internal abstract Robot Clone(Robot robot);

    internal Robot(int legs, int arms, int heads)
    {
        Legs = legs;
        Arms = arms;
        Heads = heads;
    }

    internal Robot(Robot robot)
    {
        Legs = robot.Legs;
        Arms = robot.Arms;
        Heads = robot.Heads;
    }
}
