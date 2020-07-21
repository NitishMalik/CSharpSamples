using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class F16Factory : IAircraftFactory
    {
        protected IEngine engine;
        protected ICockPit cockpit;
        protected IWings wings;

        public virtual string FactoryName { get => "F16 Factory"; set { } }

        public virtual ICockPit createCockPit()
        {
            cockpit =  new Cockpit();
            return cockpit;
        }

        public virtual IEngine createEngine()
        {
            engine = new Engine();
            return engine;
        }

        public virtual IWings createWings()
        {
            wings = new Wings();
            return wings;
        }
    }
}
