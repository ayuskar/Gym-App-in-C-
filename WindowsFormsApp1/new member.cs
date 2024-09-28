using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class new_member : Form
    {
        public new_member()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void new_member_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Fname = txtFirstname.Text;
            string Lname = txtSecondname.Text;

            string Gender = rbtn_male.Checked ? rbtn_male.Text : rbtn_female.Text;
            DateTime Dob = DateTime.Parse(dateTimePickerDOB.Text);
            Int64 Mobile = Int64.Parse(txtmobile.Text);
            string MembershipTime = comboBoxMembership.Text;
            int Currentweight = Int32.Parse(currentweight.Text);
            int Targetweight = Int32.Parse(txttargetweight.Text);
            DateTime Joindate = DateTime.Parse(dateTimePickerJoindate.Text);
            string Gymtime = comboBoxGymtime.Text;
            int Privatecoaching = Int32.Parse(numericcoaching.Text);
            int Saunaoption = Int32.Parse(numericsauna.Text);
            int Swimming = Int32.Parse(numericswimming.Text);

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Gym; Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO Totalmembers (Fname, Lname, Gender, Dob, Mobile, Membershipvalue, Currentweight, Targetweight, Joindate, Gymtime, Saunaoption, Privatecoaching, Swimming) " +
                            "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Membershipvalue, @Currentweight, @Targetweight, @Joindate, @Gymtime, @Saunaoption, @Privatecoaching, @Swimming)";

                        cmd.Parameters.AddWithValue("@Fname", Fname);
                        cmd.Parameters.AddWithValue("@Lname", Lname);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Dob", Dob);
                        cmd.Parameters.AddWithValue("@Mobile", Mobile);
                        cmd.Parameters.AddWithValue("@Membershipvalue", MembershipTime);
                        cmd.Parameters.AddWithValue("@Currentweight", Currentweight);
                        cmd.Parameters.AddWithValue("@Targetweight", Targetweight);
                        cmd.Parameters.AddWithValue("@Joindate", Joindate);
                        cmd.Parameters.AddWithValue("@Gymtime", Gymtime);
                        cmd.Parameters.AddWithValue("@Saunaoption", Saunaoption);
                        cmd.Parameters.AddWithValue("@Privatecoaching", Privatecoaching);
                        cmd.Parameters.AddWithValue("@Swimming", Swimming);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved! Welcome to Best Fitness");
                            clearAll();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An SQL error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearAll(); 
        }

        public void clearAll()
        {
            txtFirstname.Clear();
            txtSecondname.Clear();
            rbtn_male.Checked = false;
            rbtn_female.Checked = false;
            dateTimePickerDOB.Value = DateTime.Now;
            txtmobile.Clear();
            comboBoxMembership.ResetText();
            currentweight.Clear();
            txttargetweight.Clear();
            dateTimePickerJoindate.Value = DateTime.Now;
            comboBoxGymtime.ResetText();
            numericcoaching.ResetText();
            numericsauna.ResetText();
            numericswimming.ResetText();
        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_male.Checked == true)
                lbl_rbtn.Text = "Male";
            else
                if (rbtn_female.Checked == true)
                lbl_rbtn.Text = "Female";
        }

      

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericcoaching_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
