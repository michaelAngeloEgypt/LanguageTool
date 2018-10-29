using Icu;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LanguageTool.BLL
{
    public static class KhmerString
    {
        static Definitions defs;
        static KhmerString()
        {
            var defsFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Definitions.json");
            defs = JsonConvert.DeserializeObject<Definitions>(File.ReadAllText(defsFile));
        }

        // add zero width space "\u200B" to between Khmer words
        // example{ wordswordswordswordswordswordswordswords
        // after addZWSP{ words"\u200B"words"\u200B"words"\u200B"words"\u200B"words"\u200B"words"\u200B"words"\u200B"words
        public static String addZWSP(string txt)
        {
            var res = "";
            Icu.Wrapper.Init();
            var words = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", txt).ToList();
            res = String.Join("\u200B", words);
            Icu.Wrapper.Cleanup();
            return res;
        }
        // 
        /// <summary>
        /// print number of Khmer words in text
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static int wordCount(string txt)
        {
            int nums = 0;
            Icu.Wrapper.Init();
            var words = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", txt).ToList();
            nums = words.Count();
            Icu.Wrapper.Cleanup();
            return nums;
        }
        //
        /// <summary>
        /// list Khmer word after run ICU
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static String wordList(string txt)
        {
            // todo
            Icu.Wrapper.Init();
            var words = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", txt).ToList();
            var res = String.Join(Environment.NewLine, words);
            Icu.Wrapper.Cleanup();
            return txt;
        }
        // 
        /// <summary>
        /// print number of consonant in Khmer String
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int consCount(string text)
        {
            int num_Cons = -1;
            Icu.Wrapper.Init();
            var chars = BreakIterator.Split(BreakIterator.UBreakIteratorType.CHARACTER, "km-KH", text).ToList();
            num_Cons = chars.Intersect(defs.Consonants.ToList()).Count();
            Icu.Wrapper.Cleanup();
            return num_Cons;
        }
        // 
        /// <summary>
        /// print number of Khmer vowel in text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int vowelCount(string text)
        {
            int num_Vowel = -1;
            Icu.Wrapper.Init();
            var chars = BreakIterator.Split(BreakIterator.UBreakIteratorType.CHARACTER, "km-KH", text).ToList();
            num_Vowel = chars.Intersect(defs.Vowels.ToList()).Count();
            Icu.Wrapper.Cleanup();
            return num_Vowel;
        }
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int sentenceCount(string text)
        {
            int num_Sents = -1;
            Icu.Wrapper.Init();
            var sentences = text.Split(new string[] { "។" }, StringSplitOptions.None).ToList();
            num_Sents = sentences.Count();
            Icu.Wrapper.Cleanup();
            return num_Sents;
        }
        // 
        /// <summary>
        /// find longest sentence in paragraph
        /// </summary>
        /// <param name="paragraph"></param>
        /// <returns></returns>
        public static String longestSentence(string paragraph)
        {
            Icu.Wrapper.Init();
            var sentences = paragraph.Split(new string[] { "។" }, StringSplitOptions.None).ToList();
            var longestSentence = sentences.OrderByDescending(s => s.Length).FirstOrDefault();
            Icu.Wrapper.Cleanup();
            return longestSentence;
        }
        // 
        /// <summary>
        /// longest word in the text
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static String longestWord(string txt)
        {
            Icu.Wrapper.Init();
            var words = BreakIterator.Split(BreakIterator.UBreakIteratorType.WORD, "km-KH", txt).ToList();
            var longestWord = words.OrderByDescending(s => s.Length).FirstOrDefault();
            Icu.Wrapper.Cleanup();
            return longestWord;
        }
    }
}
