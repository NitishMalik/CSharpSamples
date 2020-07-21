using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class PassengerBuilder: AbstractBuilder
    {
        private Passenger passenger = new Passenger();
        public override AircraftType type { get => AircraftType.Passenger; }

        public override void buildEngine()
        {
            PrintMessage(passenger.Engine);
        }
        public override void buildCockpit()
        {
            PrintMessage(passenger.Cockpit);
        }
        public override void buildWings()
        {
            PrintMessage(passenger.Wings);
        }

        public override IAircraft getAircraft()
        {
            return passenger;
        }
    }
}
