using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IAircraftType
    {
        void Fly();

        void Service();
        void Maintian();
        IAircraftType clone();
        void setEngine(Engine engine);        
    }

    public interface IAircraftTypeEx : IAircraftType
    {
        double Weight { get; set; }       
    }

    public interface IEngine
    {
        string EngineName { get; set; }
        double HorsePower { get; set; }
        double Power { get; set; }
        object Clone();
    }

    public interface ICockPit
    {
        string CockpitName { get; set; }
        double Seater { get; set; }
        double Windows { get; set; }
        object Clone();
    }

    public interface IWings
    {
        string WingName { get; set; }
        long Width { get; set; }
        string Material { get; set; }
    }

    public interface IAircraftFactory
    {
        IEngine createEngine();
        IWings createWings();
        ICockPit createCockPit();

        string FactoryName { get; set; }
    }
}
