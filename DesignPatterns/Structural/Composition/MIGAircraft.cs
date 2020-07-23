using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class MIGAircraft : IAircraftType, IAlliancePart
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
            Console.WriteLine("MIG needs 3 people to maintain");
            return 3;
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
