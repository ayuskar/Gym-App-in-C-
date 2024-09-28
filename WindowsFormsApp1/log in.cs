using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = txtname.Text;
            string password = txtpassword.Text;

            // Perform the login authentication
            if (username == "Admin" && password == "Admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the password textbox
            txtpassword.Text = "";
        }

    }
}
