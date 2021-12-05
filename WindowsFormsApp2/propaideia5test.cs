using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class propaideia5test : Form
    {
        public propaideia5test()
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
            // Αρχικοποίηση μετρητή σωστών απαντήσεων
            int correct = 0;

            // Ερώτηση 1
            if (this.checkedListBox1.SelectedIndex.Equals(0))
            {
                this.checkedListBox1.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox1.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 2
            if (this.checkedListBox2.SelectedIndex.Equals(2))
            {
                this.checkedListBox2.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox2.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 3
            if (this.checkedListBox3.SelectedIndex.Equals(2))
            {
                this.checkedListBox3.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox3.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 4
            if (this.checkedListBox4.SelectedIndex.Equals(0))
            {
                this.checkedListBox4.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox4.BackColor = System.Drawing.Color.Red;
            }

            // Εμφάνιση σκορ
            this.scoreBox.Text = "Το σκορ σας είναι: " + correct + "/4";
            this.scoreBox.Visible = true;

            // Σύνδεση με βάση
            String sql = "";
            sql = "UPDATE [Students] SET Score5 = @correct WHERE [FirstName] = @fname and [SecondName] = @lname";
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dimitris\source\repos\WindowsFormsApp2\WindowsFormsApp2\math.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            // Πέρασμα στοιχείων με ασφαλή τρόπο
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.Parameters.Add("@fname", SqlDbType.VarChar).Value = login.firstname;
            adapter.InsertCommand.Parameters.Add("@lname", SqlDbType.VarChar).Value = login.surname;
            adapter.InsertCommand.Parameters.Add("@correct", SqlDbType.VarChar).Value = correct;
            adapter.InsertCommand.ExecuteNonQuery();
        }
    }
}
