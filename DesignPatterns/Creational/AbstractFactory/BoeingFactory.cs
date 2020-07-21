using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class BoeingFactory: IAircraftFactory
    {
        protected IEngine engine;
        protected ICockPit cockpit;
        protected IWings wings;

        public string FactoryName { get => "Boeing Factory"; set { } }
        public virtual ICockPit createCockPit()
        {
            cockpit = new EconomicalModelCockpit();
            return cockpit;
        }

        public virtual IEngine createEngine()
        {
            engine = new EconomicalModelEngine();
            return engine;
        }

        public virtual IWings createWings()
        {
            wings = new EconomicModelWings();
            return wings;
        }
    }
}
