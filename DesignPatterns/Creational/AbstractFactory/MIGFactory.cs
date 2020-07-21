using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class MIGFactory : IAircraftFactory
    {
        protected IEngine engine;
        protected ICockPit cockpit;
        protected IWings wings;

        public string FactoryName { get => "MIG Factory"; set { } }
        public virtual ICockPit createCockPit()
        {
            cockpit = new AverageModelCockpit();
            return cockpit;
        }

        public virtual IEngine createEngine()
        {
            engine = new AverageModelEngine();
            return engine;
        }

        public virtual IWings createWings()
        {
            wings = new AverageModelWings();
            return wings;
        }
    }
}
