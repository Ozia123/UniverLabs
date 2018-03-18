namespace lab1.Strategies {
    public class RemoveStrategy : Strategy {
        public override string RegularExpression => @"'[\w\s]*' *remove *'[\w\s]*'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0].Replace(strings[1], "");
        }
    }
}