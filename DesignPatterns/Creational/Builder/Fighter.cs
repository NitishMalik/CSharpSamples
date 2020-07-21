using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Fighter : IAircraft
    {
        public string Name { get => "F-16"; }
        private string _engine;
        public string Engine { get => "Fighter Engine"; set => _engine = value; }

        private string _cockpit;
        public string Cockpit { get => "Fighter Cockpit"; set => _cockpit = value; }

        private string _wings;
        public string Wings { get => "Fighter Wings"; set => _wings = value; }

        private string _utilities;
        public string Utilities { get => "No support"; set => _utilities = value; }        
    }
}
