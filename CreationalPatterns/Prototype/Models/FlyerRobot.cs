using Prototype.Models.Abstractions;

namespace Prototype.Models;

internal class FlyerRobot : Robot
{
    internal int Speed { get; set; }

    internal FlyerRobot(int speed)
        : base(2, 2, 1)
    {
        Speed = speed;
    }

    internal FlyerRobot(FlyerRobot robot)
        : base(robot)
    {
        Speed = robot.Speed;
    }

    internal override Robot Clone(Robot robot)
    {
        return new FlyerRobot(this);
    }

    public override string ToString()
    {
        return $"FlyerRobot: Speed={Speed}, Legs={Legs}, Arms={Arms}, Heads={Heads}";
    }
}
