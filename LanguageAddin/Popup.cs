using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageAddin
{
    public partial class Popup : Form
    {
        public Popup(string content)
        {
            //better solution: dislay the contents from a temp word document
            InitializeComponent();
            //lblContent.Text = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(content));
            lblContent.Text = content;
        }
    }
}
