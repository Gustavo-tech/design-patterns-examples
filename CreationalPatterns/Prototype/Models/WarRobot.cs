using Prototype.Models.Abstractions;

namespace Prototype.Models;

internal class WarRobot : Robot
{
    internal string GunType { get; set; }

    internal WarRobot(string gunType)
        : base(2, 2, 1)
    {
        GunType = gunType;
    }

    internal WarRobot(WarRobot robot)
        : base(robot)
    {
        GunType = robot.GunType;
    }

    internal override Robot Clone(Robot robot)
    {
        return new WarRobot(this);
    }

    public override string ToString()
    {
        return $"WarRobot: GunType={GunType}, Legs={Legs}, Arms={Arms}, Heads={Heads}";
    }
}
