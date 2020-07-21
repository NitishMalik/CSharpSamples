using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Wings : IWings
    {
        public string WingName { get => "Base Model"; set { } }
        public long Width { get => 1000; set { } }
        public string Material { get => "Aluminium"; set { } }
    }
    public class TopModelWings : IWings
    {
        public string WingName { get => "Top Model"; set { } }
        public long Width { get => 1000; set { } }
        public string Material { get => "Aluminium light"; set { } }
    }

    public class AverageModelWings : IWings
    {
        public string WingName { get => "Average Model"; set { } }
        public long Width { get => 1000; set { } }
        public string Material { get => "Aluminium dark"; set { } }
    }

    public class EconomicModelWings : IWings
    {
        public string WingName { get => "Economic Model"; set { } }
        public long Width { get => 1000; set { } }
        public string Material { get => "Aluminium reused"; set { } }
    }
}
