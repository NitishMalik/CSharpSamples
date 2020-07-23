using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public abstract class AbstractCorolla
    {
        protected CorollaImplementation _imp;
        public AbstractCorolla(CorollaImplementation imp)
        {
            _imp = imp;
        }
        public abstract void ListSafetyMeasures();

        public abstract void IsRighthanded();
    }
}
