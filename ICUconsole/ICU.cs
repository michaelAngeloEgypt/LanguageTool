using Icu;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ICUconsole
{
    public static class ICU
    {
        public static Statistics DoStuff(string infile)
        {
            Icu.Wrapper.Init();
            var res = WorkWithDocument(infile);
            Icu.Wrapper.Cleanup();

            return res;
            //return new Statistics();
        }
        #region UTL
        private static Statistics WorkWithDocument(string inputFile)
        {
            try
            {
                var contents = File.ReadAllText(inputFile);
                var defsFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Definitions.json");

                //var cam = new Icu.Locale("km-KH");
                //var bi = new Icu.RuleBasedBreakIterator(Icu.BreakIterator.UBreakIteratorType.WORD, cam);
                //bi.SetText(contents);
                //var count = 0;
                //while (bi.MoveNext() > 0)
                //    count++;
                // txtNumWords.Text = count.ToString();


                var words = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", contents).ToList();
                //var sentences = BreakIterator.Split(BreakIterator.UBreakIteratorType.SENTENCE, "km-KH", contents);
                //var longestSentence = sentences.OrderByDescending(s=>s.Length).FirstOrDefault();
                var chars = BreakIterator.Split(BreakIterator.UBreakIteratorType.CHARACTER, "km-KH", contents).ToList();
                var sentences = contents.Split(new string[] { "។" }, StringSplitOptions.None).ToList();
                var longestSentence = sentences.OrderByDescending(s => s.Length).FirstOrDefault();
                var longestSentenceWords = longestSentence.Split(new string[] { "។" }, StringSplitOptions.None);
                var longestSentenceWordsAPI = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", longestSentence).ToList();
                var longestWord = words.OrderByDescending(s => s.Length).FirstOrDefault();
                var longestWordChars = BreakIterator.Split(BreakIterator.UBreakIteratorType.CHARACTER, "km-KH", longestWord).ToList();

                var defs = JsonConvert.DeserializeObject<Definitions>(File.ReadAllText(defsFile));

                return new Statistics()
                {
                    //Sentences = (bi.Boundaries.Length + 1).ToString(),
                    Sentences = sentences.Count().ToString(),
                    Words = words.Count().ToString(),
                    Consonants = chars.Intersect(defs.Consonants.ToList()).Count().ToString(),
                    Vowels = chars.Intersect(defs.Vowels.ToList()).Count().ToString(),

                    LongestSentence = longestSentence,
                    LongestSentenceWords = longestSentenceWordsAPI.Count().ToString(),
                    //LongestSentenceWords = longestSentence?.Count().ToString(),

                    LongestWord = longestWord,
                    LongestWordChars = longestWordChars.Count().ToString(),

                    WordList = String.Join(Environment.NewLine, words),
                    AddingZWSP = String.Join("\u200B", words),
            };
            }
            catch (Exception x)
            {
                XLogger.Error(x);
                return null;
            }
        }
        #endregion UTL
    }
}
