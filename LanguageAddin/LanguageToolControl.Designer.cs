namespace LanguageAddin
{
    partial class LanguageToolControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLongestWord = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLongestWordChars = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.llViewWords = new System.Windows.Forms.LinkLabel();
            this.lblVowels = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblConsonants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLongestSentence = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLongestSentenceWords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnAddZwsp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLongestWord
            // 
            this.lblLongestWord.AutoSize = true;
            this.lblLongestWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLongestWord.Location = new System.Drawing.Point(166, 522);
            this.lblLongestWord.Name = "lblLongestWord";
            this.lblLongestWord.Size = new System.Drawing.Size(0, 24);
            this.lblLongestWord.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(14, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Longest Word Chars:";
            // 
            // lblLongestWordChars
            // 
            this.lblLongestWordChars.AutoSize = true;
            this.lblLongestWordChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestWordChars.ForeColor = System.Drawing.Color.Red;
            this.lblLongestWordChars.Location = new System.Drawing.Point(226, 571);
            this.lblLongestWordChars.Name = "lblLongestWordChars";
            this.lblLongestWordChars.Size = new System.Drawing.Size(0, 24);
            this.lblLongestWordChars.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(181, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddZwsp);
            this.panel1.Controls.Add(this.lblLongestWord);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblLongestWordChars);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 696);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(13, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Longest Word:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(17, 613);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(123, 47);
            this.btnAnalyze.TabIndex = 11;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.llViewWords);
            this.splitContainer1.Panel1.Controls.Add(this.lblVowels);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.lblConsonants);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblWords);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblSentences);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lblLongestSentenceWords);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(546, 497);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 17;
            // 
            // llViewWords
            // 
            this.llViewWords.AutoSize = true;
            this.llViewWords.Enabled = false;
            this.llViewWords.Location = new System.Drawing.Point(180, 71);
            this.llViewWords.Name = "llViewWords";
            this.llViewWords.Size = new System.Drawing.Size(69, 13);
            this.llViewWords.TabIndex = 20;
            this.llViewWords.TabStop = true;
            this.llViewWords.Text = "view words...";
            this.llViewWords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewWords_LinkClicked);
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowels.ForeColor = System.Drawing.Color.Red;
            this.lblVowels.Location = new System.Drawing.Point(136, 142);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(0, 24);
            this.lblVowels.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(15, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vowels:";
            // 
            // lblConsonants
            // 
            this.lblConsonants.AutoSize = true;
            this.lblConsonants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsonants.ForeColor = System.Drawing.Color.Red;
            this.lblConsonants.Location = new System.Drawing.Point(136, 105);
            this.lblConsonants.Name = "lblConsonants";
            this.lblConsonants.Size = new System.Drawing.Size(0, 24);
            this.lblConsonants.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(15, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consonants:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Words:";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.ForeColor = System.Drawing.Color.Red;
            this.lblWords.Location = new System.Drawing.Point(91, 65);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(0, 24);
            this.lblWords.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sentences:";
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentences.ForeColor = System.Drawing.Color.Red;
            this.lblSentences.Location = new System.Drawing.Point(148, 26);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(0, 24);
            this.lblSentences.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLongestSentence);
            this.panel2.Location = new System.Drawing.Point(13, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 176);
            this.panel2.TabIndex = 24;
            // 
            // lblLongestSentence
            // 
            this.lblLongestSentence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLongestSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestSentence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLongestSentence.Location = new System.Drawing.Point(0, 0);
            this.lblLongestSentence.Name = "lblLongestSentence";
            this.lblLongestSentence.Size = new System.Drawing.Size(425, 176);
            this.lblLongestSentence.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(13, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Longest Sentence Words:";
            // 
            // lblLongestSentenceWords
            // 
            this.lblLongestSentenceWords.AutoSize = true;
            this.lblLongestSentenceWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestSentenceWords.ForeColor = System.Drawing.Color.Red;
            this.lblLongestSentenceWords.Location = new System.Drawing.Point(259, 260);
            this.lblLongestSentenceWords.Name = "lblLongestSentenceWords";
            this.lblLongestSentenceWords.Size = new System.Drawing.Size(0, 24);
            this.lblLongestSentenceWords.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Longest Sentence:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(43, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Khmer";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(545, 71);
            this.pnlTitle.TabIndex = 19;
            // 
            // btnAddZwsp
            // 
            this.btnAddZwsp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddZwsp.Enabled = false;
            this.btnAddZwsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddZwsp.ForeColor = System.Drawing.Color.White;
            this.btnAddZwsp.Location = new System.Drawing.Point(307, 613);
            this.btnAddZwsp.Name = "btnAddZwsp";
            this.btnAddZwsp.Size = new System.Drawing.Size(123, 47);
            this.btnAddZwsp.TabIndex = 23;
            this.btnAddZwsp.Text = "Add ZWSP";
            this.btnAddZwsp.UseVisualStyleBackColor = false;
            this.btnAddZwsp.Click += new System.EventHandler(this.btnAddZwsp_Click);
            // 
            // LanguageToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitle);
            this.Name = "LanguageToolControl";
            this.Size = new System.Drawing.Size(545, 767);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLongestWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLongestWordChars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblConsonants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLongestSentenceWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.LinkLabel llViewWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLongestSentence;
        private System.Windows.Forms.Button btnAddZwsp;
    }
}
