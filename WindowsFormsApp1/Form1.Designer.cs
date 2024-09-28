namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMembermenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMembermenuStrip,
            this.newStaffToolStripMenuItem,
            this.searchMemberToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // newMembermenuStrip
            // 
            this.newMembermenuStrip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newMembermenuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newMembermenuStrip.BackgroundImage")));
            this.newMembermenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newMembermenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newMembermenuStrip.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.newMembermenuStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newMembermenuStrip.Name = "newMembermenuStrip";
            this.newMembermenuStrip.Size = new System.Drawing.Size(113, 24);
            this.newMembermenuStrip.Text = "New member";
            this.newMembermenuStrip.Click += new System.EventHandler(this.newMembermenuStrip_Click);
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.newStaffToolStripMenuItem.Text = "Bill";
            this.newStaffToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // searchMemberToolStripMenuItem
            // 
            this.searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            this.searchMemberToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.searchMemberToolStripMenuItem.Text = "Search member";
            this.searchMemberToolStripMenuItem.Click += new System.EventHandler(this.searchMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteMemberToolStripMenuItem.Text = "Delete member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.logOutToolStripMenuItem.Text = "Log OUT";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.updateToolStripMenuItem.Text = "Update member";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 437);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMembermenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

