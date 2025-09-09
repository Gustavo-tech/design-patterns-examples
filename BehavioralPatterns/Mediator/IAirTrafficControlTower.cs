using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator;
internal interface IAirTrafficControlTower
{
    void RequestTakeOff(IAirplane airplane);
    void RequestLanding(IAirplane airplane);
}
