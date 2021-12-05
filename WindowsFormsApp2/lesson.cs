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
    public partial class lesson : Form
    {
        public lesson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            exam ss = new exam();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            decision ss = new decision();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }
    }
}
