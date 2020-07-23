using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class CorollaModelL : AbstractCorolla
    {
        public CorollaModelL(CorollaImplementation imp): base(imp)
        {
            _imp = imp;
        }
        public override void IsRighthanded()
        {
            Console.WriteLine($"Am i for right hand drive country - {_imp.IsRightHanded()}");            
        }

        public override void ListSafetyMeasures()
        {
            _imp.ListSafetyMeasures();
        }
    }
}
