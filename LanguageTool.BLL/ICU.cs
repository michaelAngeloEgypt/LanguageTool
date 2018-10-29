using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTool.BLL
{
    public static class ICU
    {
        public static void DoOperation(string operation, string filename)
        {
            var res = "";
            var contents = File.ReadAllText(filename);
            switch (operation)
            {
                case "addZWSP":
                    res = KhmerString.addZWSP(contents).ToString();
                    break;
                case "wordCount":
                    res = KhmerString.wordCount(contents).ToString();
                    break;
                case "wordList":
                    res = KhmerString.wordList(contents).ToString();
                    break;
                case "consCount":
                    res = KhmerString.consCount(contents).ToString();
                    break;
                case "vowelCount":
                    res = KhmerString.vowelCount(contents).ToString();
                    break;
                case "sentenceCount":
                    res = KhmerString.sentenceCount(contents).ToString();
                    break;
                case "longestSentence":
                    res = KhmerString.longestSentence(contents).ToString();
                    break;
                case "longestWord":
                    res = KhmerString.longestWord(contents).ToString();
                    break;
                default:
                    break;
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"result: \n{res}");
        }

    }
}
