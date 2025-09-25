using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy;
internal interface ICalculationStrategy
{
    int Calculate(int value1, int value2);
}
