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
    public partial class exam : Form
    {
        public exam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            decision ss = new decision();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void exam_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia2test ss = new propaideia2test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia4test ss = new propaideia4test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia1test ss = new propaideia1test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia3test ss = new propaideia3test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia5test ss = new propaideia5test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia6test ss = new propaideia6test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia7test ss = new propaideia7test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia8test ss = new propaideia8test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia9test ss = new propaideia9test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            propaideia10test ss = new propaideia10test();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            genikoTest ss = new genikoTest();
            ss.Show();
            ss.Top = this.Top;
            ss.Left = this.Left;
        }
    }
}
