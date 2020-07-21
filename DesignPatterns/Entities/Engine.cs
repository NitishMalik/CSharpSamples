using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Engine : ICloneable , IEngine
    {
        public virtual string EngineName { get => "Base Engine"; set { } }
        public virtual double HorsePower { get; set; }
        public virtual double Power { get; set; }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class TopModelEngine : Engine
    {
        public override string EngineName { get => "TopModel"; }
        public override double HorsePower { get => 2500; }
        public override double Power { get => 40; }
    }

    public class AverageModelEngine : Engine
    {
        public override string EngineName { get => "Avergae"; }
        public override double HorsePower { get => 1500; }
        public override double Power { get => 20 ;  }
    }

    public class EconomicalModelEngine : Engine
    {
        public override string EngineName { get => "Economical"; }
        public override double HorsePower { get => 1500; }
        public override double Power { get => 20; }
    }
}
