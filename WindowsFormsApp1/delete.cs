using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data. Confirm?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .; database = Gym; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Totalmembers where MID =" + textBox1.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .; database = Gym; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Members where MID =" + textBox1.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = Gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Fname, Lname, Mobile, Membershipvalue from Totalmembers "; // Select only Fname, Lname , Mobile and Membershipvalue columns
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = Gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // Assuming you have a DataGridView control named dataGridView1 to display the data
            cmd.CommandText = "SELECT * FROM Totalmembers";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Totalmembers");
            dataGridView1.DataSource = DS.Tables["Totalmembers"];

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      


                }
            }

