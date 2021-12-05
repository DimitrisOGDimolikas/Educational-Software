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
    public partial class statistics : Form
    {
        public statistics()
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

        private void statistics_Load(object sender, EventArgs e)
        {
            // Σύνδεση με βάση
            String sql = "";
            sql = "SELECT Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10, ScoreEpanalhptiko FROM [Students] WHERE [FirstName] = @fname and [SecondName] = @lname";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dimitris\source\repos\WindowsFormsApp2\WindowsFormsApp2\math.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapter = new SqlDataAdapter();

            con.Open();

            adapter.SelectCommand = new SqlCommand(sql, con);
            adapter.SelectCommand.Parameters.Add("@fname", SqlDbType.VarChar).Value = login.firstname;
            adapter.SelectCommand.Parameters.Add("@lname", SqlDbType.VarChar).Value = login.surname;
            SqlDataReader da = adapter.SelectCommand.ExecuteReader();

            // Mετατροπή δεδομένων ώστε να περαστούν στα Textbox
            da.Read();
            string c1 = da["Score1"].ToString();
            string c2 = da["Score2"].ToString();
            string c3 = da["Score3"].ToString();
            string c4 = da["Score4"].ToString();
            string c5 = da["Score5"].ToString();
            string c10 = da["Score10"].ToString();
            string c9 = da["Score9"].ToString();
            string c8 = da["Score8"].ToString();
            string c7 = da["Score7"].ToString();
            string c6 = da["Score6"].ToString();

            string cEp = da["ScoreEpanalhptiko"].ToString();

            this.textBox1.Text = c1;
            this.textBox2.Text = c2;
            this.textBox3.Text = c3;
            this.textBox4.Text = c4;
            this.textBox5.Text = c5;
            this.textBox10.Text = c6;
            this.textBox9.Text = c7;
            this.textBox8.Text = c8;
            this.textBox7.Text = c9;
            this.textBox6.Text = c10;

            this.textBox11.Text = cEp;

            //Προετοιμασία διαδικασίας για εύρεση του min
            int cc1, cc2, cc3, cc4, cc5, cc6, cc7, cc8, cc9, cc10;
            int[] scores = new int[10];

            /* Βάζω το 11 γιατί μεγαλύτερο από κάθε άλλο σκορ, οπότε αν κάποιο σκορ 
             * είναι null γιατί δεν έχει ολοκληρωθεί το αντίστοιχο τεστ δεν το 
             * παίρνουμε ουσιαστικά υπόψη μας στην διαδικασία εύρεσης του min */
            try
            {
                cc1 = Int16.Parse(c1);
                scores[0] = cc1;
            }
            catch (FormatException) {
                cc1 = 11;
                scores[0] = cc1;
            }

            try
            {
                cc2 = Int16.Parse(c2);
                scores[1] = cc2;
            }
            catch (FormatException) {
                cc2 = 11;
                scores[1] = cc2;
            }

            try
            {
                cc3 = Int16.Parse(c3);
                scores[2] = cc3;
            }
            catch (FormatException) {
                cc3 = 11;
                scores[2] = cc3;
            }

            try
            {
                cc4 = Int16.Parse(c4);
                scores[3] = cc4;
            }
            catch (FormatException) {
                cc4 = 11;
                scores[3] = cc4;
            }

            try
            {
                cc5 = Int16.Parse(c5);
                scores[4] = cc5;
            }
            catch (FormatException) {
                cc5 = 11;
                scores[4] = cc5;
            }

            try
            {
                cc6 = Int16.Parse(c6);
                scores[5] = cc6;
            }
            catch (FormatException) {
                cc6 = 11;
                scores[5] = cc6;
            }
            try
            {
                cc7 = Int16.Parse(c7);
                scores[6] = cc7;
            }
            catch (FormatException) {
                cc7 = 11;
                scores[6] = cc7;
            }

            try
            {
                cc8 = Int16.Parse(c8);
                scores[7] = cc8;
            }
            catch (FormatException) {
                cc8 = 11;
                scores[7] = cc8;
            }

            try
            {
                cc9 = Int16.Parse(c9);
                scores[8] = cc9;
            }
            catch (FormatException) {
                cc9 = 11;
                scores[8] = cc9;
            }

            try
            {
                cc10 = Int16.Parse(c10);
                scores[9] = cc10;
            }
            catch (FormatException) {
                cc10 = 11;
                scores[9] = cc10;
            }

            /*Εύρεση min και ορισμός αυτού, προφανώς, αν έχει ολοκληρωθεί μόνο 
             *ένα τεστ αυτό θα είναι ταυτόχρονα max και min άρα θα παρουσιάζεται
             *και ως το τελευταίο*/
            int min = 11;
            int tmp = 0;

            for (int i = 0; i < 10; i++) {
                if (scores[i] < min)
                {
                    min = scores[i];
                    //Κρατάω τον αριθμό της προπαίδειας με το χαμηλότερο σκορ
                    tmp = i+1;
                }   
            }

            string prp = tmp.ToString();

            if (min == 11)
            {
                // Περίπτωση πρώτου ανοίγματος στατιστικών νέου χρήστη
                this.textBox12.Text = "Kάντε ένα test πρώτα";
            }
            else
            {
                this.textBox12.Text = "Προπαίδεια του " + tmp;
            }
        }

        private void statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}