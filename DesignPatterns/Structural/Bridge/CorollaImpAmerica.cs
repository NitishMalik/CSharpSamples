using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class CorollaImpAmerica : CorollaImplementation
    {
        public override bool IsRightHanded()
        {
            return false;
        }

        public override void ListSafetyMeasures()
        {
            Console.WriteLine("6 Airbags necessary");
            Console.WriteLine("Car Insurance mandatory");
        }
    }
}
