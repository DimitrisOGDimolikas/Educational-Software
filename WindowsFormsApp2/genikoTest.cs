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
    public partial class genikoTest : Form
    {
        public genikoTest()
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
            if (this.checkedListBox1.SelectedIndex.Equals(1))
            {
                this.checkedListBox1.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox1.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 2
            if (this.checkedListBox2.SelectedIndex.Equals(0))
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
            if (this.checkedListBox4.SelectedIndex.Equals(2))
            {
                this.checkedListBox4.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox4.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 5
            if (this.checkedListBox9.SelectedIndex.Equals(0))
            {
                this.checkedListBox9.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox9.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 6
            if (this.checkedListBox8.SelectedIndex.Equals(3))
            {
                this.checkedListBox8.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox8.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 7
            if (this.checkedListBox7.SelectedIndex.Equals(3))
            {
                this.checkedListBox7.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox7.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 8
            if (this.checkedListBox6.SelectedIndex.Equals(1))
            {
                this.checkedListBox6.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox6.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 9
            if (this.checkedListBox5.SelectedIndex.Equals(1))
            {
                this.checkedListBox5.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox5.BackColor = System.Drawing.Color.Red;
            }

            // Ερώτηση 10
            if (this.checkedListBox10.SelectedIndex.Equals(0))
            {
                this.checkedListBox10.BackColor = System.Drawing.Color.LightGreen;
                correct++;
            }
            else
            {
                this.checkedListBox10.BackColor = System.Drawing.Color.Red;
            }

            // Εμφάνιση σκορ
            this.scoreBox.Text = "Το σκορ σας είναι: " + correct + "/10";
            this.scoreBox.Visible = true;

            // Σύνδεση με βάση
            String sql = "";
            sql = "UPDATE [Students] SET ScoreEpanalhptiko = @correct WHERE [FirstName] = @fname and [SecondName] = @lname";
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
