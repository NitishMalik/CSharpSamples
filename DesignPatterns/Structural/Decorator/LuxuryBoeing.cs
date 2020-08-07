using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class LuxuryBoeing : BoeingAbstract
    {
        private IAircraftTypeEx boeing;

        public LuxuryBoeing(IAircraftTypeEx aircraft)
        {
            boeing = aircraft;
        }
        public override double Weight { get => boeing.Weight + 100 ; set { } }        
    }
}
