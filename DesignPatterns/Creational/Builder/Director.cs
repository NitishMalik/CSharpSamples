using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Director
    {
        private AbstractBuilder builder = null;
        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void construct()
        {
            switch (builder.type)
            {
                case AircraftType.Fighter:
                    builder.buildCockpit();
                    builder.buildEngine();
                    builder.buildWings();
                    break;
                case AircraftType.Passenger:
                    builder.buildCockpit();
                    builder.buildEngine();
                    builder.buildWings();
                    builder.buildUtilities();
                    break;
                default:
                    return;
            }
        }
    }
}
