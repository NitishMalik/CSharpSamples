using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FighterSixteen
    {
        protected IEngine engine;
        protected ICockPit cockpit;

        //Factory Method 
        protected virtual FighterSixteen makeFighterPlane()
        {
            engine = new TopModelEngine();
            cockpit = new TopModelCockpit();
            return this;
        }

        private void Runway()
        {
            Console.WriteLine($"Stay away, i have {this.engine.EngineName} engine and a cockpit {cockpit.CockpitName}");
        }

        public void Fly()
        {
            FighterSixteen f16 = makeFighterPlane();
            f16.Runway();
        }
    }
}
