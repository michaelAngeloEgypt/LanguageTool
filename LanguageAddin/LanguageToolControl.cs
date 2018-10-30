using ICUconsole;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LanguageAddin
{
    public partial class LanguageToolControl : UserControl
    {
        Statistics res = null;

        public LanguageToolControl()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                string textFromDoc;
                var app = (Microsoft.Office.Interop.Word._Application)Globals.ThisAddIn.Application;
                //Microsoft.Office.Interop.Word.Document document = this.Application.ActiveDocument;

                var doc = app.Selection.Document;
                textFromDoc = app.Selection.Text;
                doc.Content.Select();
                Microsoft.Office.Interop.Word.Range rng = doc.Content;
                var contents = rng.Text;


                var outFile = @"C:\LanguageTool\statistics.json";
                var inFile = @"C:\LanguageTool\camText.txt";
                File.WriteAllText(inFile, contents, Encoding.Unicode);
                outFile.DeleteFile();
                Utilities.ScanFile(inFile, outFile);

                var resOutput = File.ReadAllText(outFile);
                //var res = new Statistics();
                //res.Words = resOutput.After("\"Words\":\"").Before("\"");
                res = JsonConvert.DeserializeObject<Statistics>(File.ReadAllText(outFile));


                lblSentences.Text = res.Sentences;
                lblWords.Text = res.Words;
                lblConsonants.Text = res.Consonants;
                lblVowels.Text = res.Vowels;

                lblLongestWord.Text = res.LongestWord;
                lblLongestWordChars.Text = res.LongestWordChars;

                lblLongestSentence.Text = res.LongestSentence;
                lblLongestSentenceWords.Text = res.LongestSentenceWords;

                llViewWords.Enabled = true;
                btnAddZwsp.Enabled = true;
            }
            catch (Exception x)
            {
                XLogger.Error(x);
                MessageBox.Show("Something went wrong");
            }
        }



        private void llViewWords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (res == null)
                return;

            Popup pp = new Popup(res.WordList);
            pp.ShowDialog();
        }

        private void llAdddingZWSP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (res == null)
                return;

            Popup pp = new Popup(res.AddingZWSP);
            pp.ShowDialog();
        }

        private void btnAddZwsp_Click(object sender, EventArgs e)
        {
            if (res == null)
                return;

            var app = (Microsoft.Office.Interop.Word._Application)Globals.ThisAddIn.Application;
            var doc = app.ActiveDocument;
            var rng = doc.Range(0, 0);
            rng.Text = res.AddingZWSP;

        }
    }
}
