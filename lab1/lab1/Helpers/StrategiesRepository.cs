using System.Collections.Generic;
using lab1.Strategies;

namespace lab1.Helpers {
    class StrategiesRepository {
        public List<Strategy> Strategies { get; }

        public StrategiesRepository() {
            Strategies = new List<Strategy>();

            Strategies.Add(new ConcatStrategy());
            Strategies.Add(new ReplaceStrategy());
            Strategies.Add(new RemoveStrategy());
            Strategies.Add(new IndexOfStrategy());
            Strategies.Add(new LengthOfStrategy());
            Strategies.Add(new DoubleVowelsInStrategy());
        }

        public void AddStrategy(Strategy strategy) {
            Strategies.Add(strategy);
        }
    }
}