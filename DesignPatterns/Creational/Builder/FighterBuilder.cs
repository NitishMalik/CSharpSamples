using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FighterBuilder : AbstractBuilder
    {
        private Fighter fighter = new Fighter();

        public override AircraftType type { get => AircraftType.Fighter;}

        public override void buildEngine() 
        {
            PrintMessage(fighter.Engine);
        }
        public override void buildCockpit() {
            PrintMessage(fighter.Cockpit);
        }
        public override void buildWings() {
            PrintMessage(fighter.Wings);
        }

        public override IAircraft getAircraft()
        {
            return fighter;   
        }
    }
}
