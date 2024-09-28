namespace WindowsFormsApp1
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.Label();
            this.lblcoaching = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblswimming = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalswimming = new System.Windows.Forms.Label();
            this.totalprivate = new System.Windows.Forms.Label();
            this.totalsauna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(664, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 34);
            this.label11.TabIndex = 25;
            this.label11.Text = "Best Fitness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "ENTER ID";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(259, 90);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(230, 22);
            this.number.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 254);
            this.dataGridView1.TabIndex = 29;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(541, 373);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(38, 16);
            this.total.TabIndex = 33;
            this.total.Text = "Total";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // lblcoaching
            // 
            this.lblcoaching.AutoSize = true;
            this.lblcoaching.Location = new System.Drawing.Point(235, 298);
            this.lblcoaching.Name = "lblcoaching";
            this.lblcoaching.Size = new System.Drawing.Size(107, 16);
            this.lblcoaching.TabIndex = 34;
            this.lblcoaching.Text = "Private coaching";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblswimming
            // 
            this.lblswimming.AutoSize = true;
            this.lblswimming.Location = new System.Drawing.Point(235, 339);
            this.lblswimming.Name = "lblswimming";
            this.lblswimming.Size = new System.Drawing.Size(68, 16);
            this.lblswimming.TabIndex = 36;
            this.lblswimming.Text = "Swimming";
            this.lblswimming.Click += new System.EventHandler(this.lblswimming_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Membership fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sauna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Weight category";
            // 
            // totalswimming
            // 
            this.totalswimming.AutoSize = true;
            this.totalswimming.Location = new System.Drawing.Point(474, 330);
            this.totalswimming.Name = "totalswimming";
            this.totalswimming.Size = new System.Drawing.Size(139, 16);
            this.totalswimming.TabIndex = 43;
            this.totalswimming.Text = "Total swimming taken:";
            // 
            // totalprivate
            // 
            this.totalprivate.AutoSize = true;
            this.totalprivate.Location = new System.Drawing.Point(474, 298);
            this.totalprivate.Name = "totalprivate";
            this.totalprivate.Size = new System.Drawing.Size(179, 16);
            this.totalprivate.TabIndex = 44;
            this.totalprivate.Text = "Total private coaching taken:";
            // 
            // totalsauna
            // 
            this.totalsauna.AutoSize = true;
            this.totalsauna.Location = new System.Drawing.Point(474, 266);
            this.totalsauna.Name = "totalsauna";
            this.totalsauna.Size = new System.Drawing.Size(117, 16);
            this.totalsauna.TabIndex = 45;
            this.totalsauna.Text = "Total sauna taken:";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 459);
            this.Controls.Add(this.totalsauna);
            this.Controls.Add(this.totalprivate);
            this.Controls.Add(this.totalswimming);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblswimming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcoaching);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Bills";
            this.Text = "Bills";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lblcoaching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblswimming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalswimming;
        private System.Windows.Forms.Label totalprivate;
        private System.Windows.Forms.Label totalsauna;
    }
}