using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class AirForce : IAlliancePart
    {
        List<IAlliancePart> planes = new List<IAlliancePart>();

        public void Add(IAlliancePart plane)
        {
            planes.Add(plane);
        }
        public int getNumbOfPeopleRequired()
        {
            int total = 0;
            foreach (var item in planes)
            {
                total += item.getNumbOfPeopleRequired();
            }

            Console.WriteLine($"Total count : {total}");
            return total;
        }
    }
}
