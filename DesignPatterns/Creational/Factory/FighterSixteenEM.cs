using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FighterSixteenEM : FighterSixteen
    {
        protected override FighterSixteen makeFighterPlane()
        {
            engine = new EconomicalModelEngine();
            cockpit = new EconomicalModelCockpit();
            return this;
        }
    }
}
