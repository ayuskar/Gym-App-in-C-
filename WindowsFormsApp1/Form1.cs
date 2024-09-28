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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newMembermenuStrip.Image = Image.FromFile(@"C:\Users\DELL\OneDrive - ISMT College\Desktop\img5.png");
        }
        Boolean b = true;
        private void newMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                newMembermenuStrip.Image = Image.FromFile(@"C:\Users\DELL\OneDrive - ISMT College\Desktop\img4.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Left;
                b = true;
                newMembermenuStrip.Image = Image.FromFile(@"C:\Users\DELL\OneDrive - ISMT College\Desktop\img4.png");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newMembermenuStrip_Click(object sender, EventArgs e)
        {
            new_member nm = new new_member();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills nm = new Bills();
            nm.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_member sm = new Search_member();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete dm =  new delete();
            dm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log OUT !! Confirm?", "Log OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
                log_in lg = new log_in();
                lg.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update nm = new Update();
            nm.Show();
        }
    }
    }

