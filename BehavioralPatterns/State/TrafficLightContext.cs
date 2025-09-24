using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;
internal class TrafficLightContext
{
    public ITrafficLightState CurrentState;

    public TrafficLightContext()
    {
        CurrentState = new RedLightState();
    }

    public void ChangeLight()
    {
        CurrentState.HandleRequest(this);
    }
}
