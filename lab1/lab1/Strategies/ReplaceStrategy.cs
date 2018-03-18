namespace lab1.Strategies {
    public class ReplaceStrategy : Strategy {
        public override string RegularExpression => @"'[\w\s]*' *replace *'[\w\s]+' with '[\w\s]+'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0].Replace(strings[1], strings[2]);
        }
    }
}