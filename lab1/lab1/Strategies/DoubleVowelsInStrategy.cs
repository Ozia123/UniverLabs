using lab1.Extensions;

namespace lab1.Strategies {
    public class DoubleVowelsInStrategy : Strategy {
        public override string RegularExpression => @"doubleVowelsIn *'[\w\s]*'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0].DoubleVowels();
        }
    }
}