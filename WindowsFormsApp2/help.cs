using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            helpTxt.Rtf = "";
            helpTxt.Rtf = File.ReadAllText(@"C:\Users\Dimitris\source\repos\WindowsFormsApp2\WindowsFormsApp2\helpInstructions.rtf");
        }
    }
}
