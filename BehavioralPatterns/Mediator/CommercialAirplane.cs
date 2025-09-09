using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator;
internal class CommercialAirplane(IAirTrafficControlTower mediator) : IAirplane
{
    private readonly IAirTrafficControlTower _mediator = mediator;

    public void NotifyAirTrafficControl(string message)
    {
        Console.WriteLine($"Commercial airplane: {message}");
    }

    public void RequestLanding()
    {
        _mediator.RequestLanding(this);
    }

    public void RequestTakeOff()
    {
        _mediator.RequestTakeOff(this);
    }
}
