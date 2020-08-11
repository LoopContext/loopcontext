using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LoopContext {
    public class Program {
        public static void Main (string[] args) {
            string loopContext = File.ReadAllText("loopcontext.txt");
            MatchCollection matchList = Regex.Matches(String.Join(Environment.NewLine, loopContext), "[A-Z]");
            var list = matchList.Cast<Match>().Select(match => match.Value).ToList();
            Console.WriteLine(String.Join(String.Empty, list));
        }
    }
}
