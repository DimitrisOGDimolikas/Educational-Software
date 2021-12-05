using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class decision : Form
    {
        public decision()
        {
            InitializeComponent();
        }

        private void lessonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lesson ss = new lesson();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics ss = new statistics();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            exam ss = new exam();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void helpHome_Click(object sender, EventArgs e)
        {
            help ss = new help();
            ss.Show();
        }
    }
}
