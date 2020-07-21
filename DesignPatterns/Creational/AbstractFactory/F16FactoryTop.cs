using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class F16FactoryTop : F16Factory
    {
        public virtual string FactoryName { get => "F16 Top Model Factory"; set { } }
        public override ICockPit createCockPit()
        {
            cockpit = new TopModelCockpit();
            return cockpit;
        }

        public override IEngine createEngine()
        {
            engine = new TopModelEngine();
            return engine;
        }

        public override IWings createWings()
        {
            wings = new TopModelWings();
            return wings;
        }
    }
}
