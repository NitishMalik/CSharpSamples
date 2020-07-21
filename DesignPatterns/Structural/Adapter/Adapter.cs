using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class Adapter : IAircraftType
    {
        private HotAirBallon hotAirBallon { get; set; }
        public Adapter(HotAirBallon ballon)
        {
            hotAirBallon = ballon;
        }
        public IAircraftType clone()
        {
            throw new NotImplementedException();
        }

        //Now this adaptes to the external fly(param) method
        public void Fly()
        {
            hotAirBallon.Fly(hotAirBallon.RevealGasUsed());
        }

        public void Maintian()
        {
            hotAirBallon.Maintian(hotAirBallon.RevealGasUsed());
        }

        public void Service()
        {
            hotAirBallon.Service();
        }

        public void setEngine(Engine engine)
        {
            hotAirBallon.setEngine(engine);
        }
    }
}
