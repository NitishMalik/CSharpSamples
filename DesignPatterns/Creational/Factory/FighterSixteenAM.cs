using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FighterSixteenAM: FighterSixteen
    {
        protected override FighterSixteen makeFighterPlane()
        {
            engine = new AverageModelEngine();
            cockpit = new AverageModelCockpit();
            return this;
        }
    }
}
