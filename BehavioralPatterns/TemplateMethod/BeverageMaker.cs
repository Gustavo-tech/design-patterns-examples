using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod;
internal abstract class BeverageMaker
{
    public void MakeBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
