namespace lab1.Strategies {
    public class ConcatStrategy : Strategy {
        public override string RegularExpression => @"'[\w\s]*' *\+ *'[\w\s]*'";

        public override string GetResult() {
            return result;
        }

        public override void Execute(string operation) {
            string[] strings = GetStrings(operation);
            result = strings[0] + strings[1];
        }
    }
}