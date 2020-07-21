using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    //Assume this is a 3 party library
    public class HotAirBallon
    {
        private string gasUsed = "Helium";
        public string RevealGasUsed() 
        {
            return gasUsed;
        }
        public void Fly(string gasToBeUsed)
        {
            Console.WriteLine($"I fly with gas {gasToBeUsed}");
        }

        public void Maintian(string gasRequired)
        {
            Console.WriteLine($"Maintainence resource is {gasRequired}");
        }

        public void Service()
        {
            Console.WriteLine("Service done");
        }

        public void setEngine(Engine engine)
        {
            throw new NotImplementedException();
        }
    }

}
