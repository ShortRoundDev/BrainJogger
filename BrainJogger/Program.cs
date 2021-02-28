using System;
using System.IO;

namespace BrainJogger
{
    class Program
    {
        static Random R = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length > 0 && args[0] == "-adv"
                ? $"{GetAdverb()} {GetVerb()} the {GetAdjective()} {GetNoun()}"
                : $"{GetVerb()} the {GetAdjective()} {GetNoun()}"
            );
        }


        public static string SelectFile(string Which)
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Which);
            return files[R.Next(files.Length)];
        }

        public static string GetNoun() => GetWord("nouns");
        public static string GetVerb() => GetWord("verbs");
        public static string GetAdjective() => GetWord("adjectives");
        public static string GetAdverb() => GetWord("adverbs");

        public static string GetWord(string Which)
        {
            var file = SelectFile(Which);
            var text = File.ReadAllLines(file);
            return text[R.Next(text.Length)];
        }
    }
}
