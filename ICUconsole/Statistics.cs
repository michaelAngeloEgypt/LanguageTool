using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICUconsole
{
    public class Statistics
    {
        public string Sentences { get; set; }
        public string Words { get; set; }
        public string Consonants { get; set; }
        public string Vowels { get; set; }

        public string LongestSentence { get; set; }
        public string LongestSentenceWords { get; set; }

        public string LongestWord { get; set; }
        public string LongestWordChars { get; set; }

        public string WordList { get; set; }
        public string AddingZWSP { get; set; }
    }
}
