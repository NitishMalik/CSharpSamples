using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FighterPrototype : IAircraftType
    {
        private IEngine engine = new TopModelEngine();
        public IAircraftType clone()
        {
            // Deep clone example
            FighterPrototype deepCopy = (FighterPrototype)this.MemberwiseClone();
            deepCopy.engine = (Engine)this.engine.Clone();
            return deepCopy;
        }

        public void Fly()
        {
            Console.WriteLine($"Flying with {this.engine.EngineName} engine");
        }

        public void Maintian()
        {
            // Dummy Method
        }

        public void Service()
        {
            // Dummy Method
        }

        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }
    }
}
