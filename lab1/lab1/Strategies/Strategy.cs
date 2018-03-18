using System.Text.RegularExpressions;

namespace lab1.Strategies {
    public abstract class Strategy {
        private const string stringsRegularExpression = @"'([\w\s]+)'";
        protected string result = null;

        public abstract string RegularExpression { get; }

        public abstract void Execute(string operation);

        public abstract string GetResult();

        private MatchCollection GetMatches(string operation, string regularExpression) {
            Regex regex = new Regex(regularExpression, RegexOptions.IgnoreCase);
            return regex.Matches(operation);
        }

        protected string[] GetStrings(string operation) {
            MatchCollection matches = GetMatches(operation, stringsRegularExpression);
            string[] strings = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++) {
                strings[i] = matches[i].Groups[1].Value;
            }
            return strings;
        }

        public bool IsValidOperation(string operation) {
            MatchCollection matches = GetMatches(operation, RegularExpression);
            if (matches.Count > 0) {
                return true;
            }
            return false;
        }
    }
}