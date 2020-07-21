using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Cockpit : ICloneable, ICockPit
    {        
        public virtual string CockpitName { get => "Base Model"; set { } }
        public virtual double Seater { get; set; }
        public virtual double Windows { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class TopModelCockpit : Cockpit
    {
        public override string CockpitName { get => "Top Model"; set { } }
        public override double Seater { get; set; }
        public override double Windows { get; set; }
    }

    public class AverageModelCockpit : Cockpit
    {
        public override string CockpitName { get => "Average Model"; set { } }
        public override double Seater { get; set; }
        public override double Windows { get; set; }
    }

    public class EconomicalModelCockpit : Cockpit
    {
        public override string CockpitName { get => "Economic Model"; set { } }
        public override double Seater { get; set; }
        public override double Windows { get; set; }
    }
}
