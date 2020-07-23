using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class CorollaImpAsia : CorollaImplementation
    {
        public override bool IsRightHanded()
        {
            return false;
        }

        public override void ListSafetyMeasures()
        {
            Console.WriteLine("Airbags as per need");
            Console.WriteLine("Drive at will, no major rules");
        }
    }
}
