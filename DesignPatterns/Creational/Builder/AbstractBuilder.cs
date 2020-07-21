using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public enum AircraftType
    {
        Fighter,
        Passenger,
        Cargo,
    }
    public interface IAircraft
    {
        public string Name { get; }
        public string Engine { get; set; }
        public string Cockpit { get; set; }
        public string Wings { get; set; }

        public string Utilities { get; set; }
    }
    public abstract class AbstractBuilder
    {
        public abstract AircraftType type { get; }
        public virtual void buildEngine() { }
        public virtual void buildCockpit() { }
        public virtual void buildWings() { }
        public virtual void buildUtilities() { } // Washroom and ktichen

        public abstract IAircraft getAircraft();      

        public void PrintMessage(string input)
        {
            Console.WriteLine(input);
        }
    }    

}
