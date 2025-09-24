using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;
internal interface ITrafficLightState
{
    void HandleRequest(TrafficLightContext context);
}
