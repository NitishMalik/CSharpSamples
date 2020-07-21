using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Passenger: IAircraft
    {
        public string Name { get => "Boeing777"; }

        private string _engine;
        public string Engine { get => "Passenger Engine"; set => _engine = value; }

        private string _cockpit;
        public string Cockpit { get => "Passenger Cockpit"; set => _cockpit = value; }

        private string _wings;
        public string Wings { get => "Passenger Wings"; set => _wings = value; }

        private string _utilities;
        public string Utilities { get => "Passenger utilities"; set => _utilities = value; }
    }
}
