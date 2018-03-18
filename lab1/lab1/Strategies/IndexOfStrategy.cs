namespace lab1.Strategies {
    public class IndexOfStrategy : Strategy {
        public override string RegularExpression => @"'[\w\s]*' *indexOf *'[\w\s]*'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0].IndexOf(strings[1], 0).ToString();
        }
    }
}