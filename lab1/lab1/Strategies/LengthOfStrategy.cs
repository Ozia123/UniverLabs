namespace lab1.Strategies {
    public class LengthOfStrategy : Strategy {
        public override string RegularExpression => @"lengthOf *'[\w\s]*'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0].Length.ToString();
        }
    }
}