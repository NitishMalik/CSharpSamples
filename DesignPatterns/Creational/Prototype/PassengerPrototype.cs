using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class PassengerPrototype : IAircraftType
    {
        private IEngine engine = new AverageModelEngine();
        public IAircraftType clone()
        {
            //Shallow Copy sample
            return this.MemberwiseClone() as PassengerPrototype;
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
