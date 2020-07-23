using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class F16Aircraft : IAircraftType, IAlliancePart
    {
        public IAircraftType clone()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public int getNumbOfPeopleRequired()
        {
            Console.WriteLine("F16 needs 5 people to maintain");
            return 5;
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
