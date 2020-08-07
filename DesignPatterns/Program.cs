using System;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------Creational----------------

            ////---- 1. Singleton Pattern --------------
            ///
            // Singleton.Instance.PrintMessage();

            ////-----2. Builder Pattern -----------------
            ///
            //FighterBuilder builder = new FighterBuilder();
            //Director director = new Director(builder);
            //director.construct();
            //Console.WriteLine(builder.getAircraft().Name);

            ////---- 3. Prototype Pattern -----------------------
            ///
            //IAircraftType fighterType = new FighterPrototype();
            //IAircraftType fighterWithAvgModel = fighterType.clone();
            //fighterWithAvgModel.setEngine(new AverageModelEngine());
            //fighterWithAvgModel.Fly();

            //IAircraftType fighterWithEconomicModel = fighterType.clone();
            //fighterWithEconomicModel.setEngine(new EconomicalModelEngine());
            //fighterWithEconomicModel.Fly();

            //// --- 4.  Factory Pattern --------------------------
            //SimpleFactory sf = new SimpleFactory();
            //FighterSixteen avgf16 = sf.getFighterPlane(FighterModel.AverageModel);
            //avgf16.Fly();
            //FighterSixteen ecmf16 = sf.getFighterPlane(FighterModel.EconomicalModel);
            //ecmf16.Fly();

            //// ---- 5. Abstract Factory ----------------------------
            //Simple factory can be used to simply process
            //F16FactoryTop topModelF16 = new F16FactoryTop();
            //AircraftFactory aFactory = new AircraftFactory(topModelF16);
            //aFactory.Fly();


            //---------- Structural ----------------

            //// ---- 1. Adapter Pattern -------
            //HotAirBallon balloon = new HotAirBallon();            
            //IAircraftType aircraft = new Adapter(balloon);
            //aircraft.Fly();

            //// --- 2. Bridge Pattern            
            //AbstractCorolla toyota = new CorollaModelL(new CorollaImpAsia());
            //toyota.IsRighthanded();
            //toyota.ListSafetyMeasures();

            //// --- 3. Composition Pattern
            //AirForce airForce = new AirForce();
            //airForce.Add(new IndianAirForce());
            //airForce.Add(new F16Aircraft());
            //airForce.Add(new MIGAircraft());

            //airForce.getNumbOfPeopleRequired();

            //// --- 4. Decorator Pattern
            IAircraftTypeEx luxury = new LuxuryBoeing(new BoeingAbstract());
            Console.WriteLine($"Weight of luxury boeing is { luxury.Weight}");

            Console.ReadLine();
        }
    }
}
