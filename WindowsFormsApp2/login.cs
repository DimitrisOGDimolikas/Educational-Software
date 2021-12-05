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
    public partial class login : Form
    {
        public static string firstname { get; set; }
        public static string surname { get; set; }

        public login()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            firstname = firstName.Text;
            surname = secondName.Text;

            if (firstname == "" || surname == "")
            {
                MessageBox.Show("Παρακαλώ εισάγετε το όνομα και το επώνυμό σας!");
            }
            else { 
                String sql = "";
                sql = "INSERT INTO [Students] (FirstName, SecondName) SELECT @fname, @lname WHERE NOT EXISTS (SELECT FirstName, SecondName FROM [Students] WHERE [FirstName] = @fname and [SecondName] = @lname)";
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dimitris\source\repos\WindowsFormsApp2\WindowsFormsApp2\math.mdf;Integrated Security=True;Connect Timeout=30");

                con.Open();

                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.Parameters.Add("@fname", SqlDbType.VarChar).Value = firstname;
                adapter.InsertCommand.Parameters.Add("@lname", SqlDbType.VarChar).Value = surname;
                adapter.InsertCommand.ExecuteNonQuery();
                    
                this.Hide();
                decision ss = new decision();
                ss.Show();
                ss.Top = this.Top;
                ss.Left = this.Left;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpHome_Click(object sender, EventArgs e)
        {
            help ss = new help();
            ss.Show();
        }
    }
}
