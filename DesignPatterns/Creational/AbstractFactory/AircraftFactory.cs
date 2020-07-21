using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class AircraftFactory
    {
        private IAircraftFactory airFactory;
        //Including these just for printing names
        private IEngine engine;
        private ICockPit cockpit;
        private IWings wings;
        public AircraftFactory(IAircraftFactory aircraftFactory)
        {
            airFactory = aircraftFactory;
        }

        //Factory Method 
        protected AircraftFactory MakeAircraft()
        {
            engine = airFactory.createEngine();
            cockpit =airFactory.createCockPit();
            wings = airFactory.createWings();
            return this;
        }

        private void Runway()
        {
            Console.WriteLine($"Stay away, I am {airFactory.FactoryName},  i have {engine.EngineName} engine , a cockpit {cockpit.CockpitName}, wings {wings.WingName}");
        }

        public void Fly()
        {
            AircraftFactory aircraft = MakeAircraft();
            aircraft.Runway();
        }

    }
}
