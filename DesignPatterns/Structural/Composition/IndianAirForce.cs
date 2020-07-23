using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class IndianAirForce : IAlliancePart
    {
        public int getNumbOfPeopleRequired()
        {
            Console.WriteLine("Indian airforce needs 5000 people to maintain");
            return 5000;
        }
    }
}
