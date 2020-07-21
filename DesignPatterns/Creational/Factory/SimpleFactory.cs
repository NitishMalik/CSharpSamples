using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public enum FighterModel
    {
        BaseModel,
        TopModel,
        AverageModel,
        EconomicalModel
    }
    public class SimpleFactory
    {
        // Simple factory method , not a pattern
        public FighterSixteen getFighterPlane( FighterModel model)
        {
            switch (model)
            {
                case FighterModel.AverageModel:
                    return new FighterSixteenAM();
                case FighterModel.EconomicalModel:
                    return new FighterSixteenEM();
                default:
                    return new FighterSixteen();
            }
        }
    }
}
