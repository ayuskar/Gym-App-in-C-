using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = Gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "SELECT * FROM Totalmembers";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS, "Totalmembers");
                dataGridView1.DataSource = DS.Tables["Totalmembers"];
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database access
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = Gym; integrated security = True";
            con.Open();
            string NameID = (textBox6.Text);
            string Fistname = textBox1.Text;
            string Lastname = textBox2.Text;
            int Privatecoachingall = Int32.Parse(textBox4.Text);

            int Saunaall = Int32.Parse(textBox3.Text);


            int Swimmingall = Int32.Parse(textBox5.Text);

            string query = "UPDATE Totalmembers SET Fname = @Fname, Lname = @Lname, Privatecoaching = @Privatecoaching, Saunaoption = @Saunaoption, Swimming = @Swimming WHERE MID = @NameID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Fname", Fistname);
            cmd.Parameters.AddWithValue("@Lname", Lastname);
            cmd.Parameters.AddWithValue("@Privatecoaching", Privatecoachingall);
            cmd.Parameters.AddWithValue("@Saunaoption", Saunaall);
            cmd.Parameters.AddWithValue("@Swimming", Swimmingall);
            cmd.Parameters.AddWithValue("@NameID", NameID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");
           
        }
    }
    }

