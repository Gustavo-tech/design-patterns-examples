using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy;
internal class SubtractionStrategy : ICalculationStrategy
{
    public int Calculate(int value1, int value2)
    {
        return value1 - value2;
    }
}
