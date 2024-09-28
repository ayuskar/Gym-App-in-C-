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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .; database = Gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


           // try
           // {
                con.Open();
                int mid = int.Parse(number.Text);
                string query = "SELECT * FROM Totalmembers WHERE MID = @mid";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@mid", mid); 
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string Fname = reader.GetString(reader.GetOrdinal("Fname"));
                    string Lname = reader.GetString(reader.GetOrdinal("Lname"));
                   int currentWeight = reader.GetInt32(reader.GetOrdinal("currentweight"));
                   int targetWeight = reader.GetInt32(reader.GetOrdinal("targetweight"));


                int sauna = reader.GetInt32(reader.GetOrdinal("Saunaoption"));
                    int privateCoachingHours = reader.GetInt32(reader.GetOrdinal("Privatecoaching"));
                 string Membershipfee = reader.GetString(reader.GetOrdinal("Membershipvalue"));
                    int Swimmingfee = reader.GetInt32(reader.GetOrdinal("Swimming"));




                // Calculating membership fees
                double weeklyfeetotal = 0;
                    switch (Membershipfee)
                    {
                        case "Begineer":
                        weeklyfeetotal = 1000;
                            break;
                        case "Intermediate":
                        weeklyfeetotal = 2000;
                            break;
                        case "Elite":
                        weeklyfeetotal = 3000;
                            break;
                    
                     }


                // Calculate weight category
                string weightCategory;
                if (currentWeight < targetWeight - 5)
                {
                    weightCategory = "Underweight";
                }
                else if (currentWeight > targetWeight + 5)
                {
                    weightCategory = "Overweight";
                }
                else
                {
                    weightCategory = "Normal";
                }

                  


                double coachingFee = privateCoachingHours * 500;
                        double saunaFee = sauna * 1500;
                       double swimmingFee = Swimmingfee * 500;
                
                       double totalFees = 4 * weeklyfeetotal + (coachingFee + saunaFee + swimmingFee);
                         // Output data labels
                    label1.Text = Fname;
                    label8.Text = Lname;
                label5.Text = "Weekly fees: NPR" + weeklyfeetotal.ToString("0.00");
                    label3.Text = "Sauna fee: NPR" + saunaFee.ToString("0.00");
                    lblcoaching.Text = "Private coaching fee: NPR" + coachingFee.ToString("0.00");
                    lblswimming.Text = "Swimmingfee: NPR" + swimmingFee.ToString("0.00");
                    total.Text = "Total fees: NPR " + totalFees.ToString("0.00");
                  label6.Text = "Weight category: " + weightCategory;
                   totalsauna.Text =  "Total sauna taken:" +sauna.ToString("0");
                totalprivate.Text = "Total private coaching hours taken:" + privateCoachingHours.ToString("0");

                  totalswimming.Text =  "Total swimming taken:" + Swimmingfee.ToString("0");
                }
                else
                {
                    MessageBox.Show("Customer NotFound ");
                }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void lblswimming_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Go back to the previous page
            this.Hide();  // Hide the current form
            Form1 previousForm = new Form1();  // Instantiate the previous form
            previousForm.Show();  // Show the previous form
        }
    }
    }























