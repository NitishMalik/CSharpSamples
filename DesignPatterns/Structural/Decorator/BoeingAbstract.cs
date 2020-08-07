using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class BoeingAbstract : IAircraftTypeEx
    {
        public virtual double Weight { get => 100; set { }}

        public IAircraftType clone()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Maintian()
        {
            throw new NotImplementedException();
        }

        public void Service()
        {
            throw new NotImplementedException();
        }

        public void setEngine(Engine engine)
        {
            throw new NotImplementedException();
        }
    }
}
