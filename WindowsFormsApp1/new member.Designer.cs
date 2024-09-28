namespace WindowsFormsApp1
{
    partial class new_member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_member));
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtSecondname = new System.Windows.Forms.TextBox();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.currentweight = new System.Windows.Forms.TextBox();
            this.dateTimePickerJoindate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMembership = new System.Windows.Forms.ComboBox();
            this.comboBoxGymtime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttargetweight = new System.Windows.Forms.TextBox();
            this.lbl_rbtn = new System.Windows.Forms.Label();
            this.numericcoaching = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericsauna = new System.Windows.Forms.NumericUpDown();
            this.numericswimming = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericcoaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsauna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericswimming)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(179, 73);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(166, 22);
            this.txtFirstname.TabIndex = 0;
            // 
            // txtSecondname
            // 
            this.txtSecondname.Location = new System.Drawing.Point(181, 110);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.Size = new System.Drawing.Size(154, 22);
            this.txtSecondname.TabIndex = 1;
            this.txtSecondname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_male.Location = new System.Drawing.Point(174, 163);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(62, 20);
            this.rbtn_male.TabIndex = 2;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            this.rbtn_male.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_female.Location = new System.Drawing.Point(242, 163);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(80, 20);
            this.rbtn_female.TabIndex = 3;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(174, 209);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(184, 252);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(161, 22);
            this.txtmobile.TabIndex = 5;
            // 
            // currentweight
            // 
            this.currentweight.Location = new System.Drawing.Point(565, 73);
            this.currentweight.Name = "currentweight";
            this.currentweight.Size = new System.Drawing.Size(158, 22);
            this.currentweight.TabIndex = 7;
            // 
            // dateTimePickerJoindate
            // 
            this.dateTimePickerJoindate.Location = new System.Drawing.Point(552, 175);
            this.dateTimePickerJoindate.Name = "dateTimePickerJoindate";
            this.dateTimePickerJoindate.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerJoindate.TabIndex = 9;
            // 
            // comboBoxMembership
            // 
            this.comboBoxMembership.FormattingEnabled = true;
            this.comboBoxMembership.Items.AddRange(new object[] {
            "Begineer",
            "Intermediate",
            "Elite"});
            this.comboBoxMembership.Location = new System.Drawing.Point(193, 304);
            this.comboBoxMembership.Name = "comboBoxMembership";
            this.comboBoxMembership.Size = new System.Drawing.Size(152, 24);
            this.comboBoxMembership.TabIndex = 10;
            // 
            // comboBoxGymtime
            // 
            this.comboBoxGymtime.FormattingEnabled = true;
            this.comboBoxGymtime.Items.AddRange(new object[] {
            "06Am - 07AM",
            "07AM - 08AM",
            "08AM - 09AM",
            "06PM - 07 PM",
            "07PM - 08PM"});
            this.comboBoxGymtime.Location = new System.Drawing.Point(565, 221);
            this.comboBoxGymtime.Name = "comboBoxGymtime";
            this.comboBoxGymtime.Size = new System.Drawing.Size(161, 24);
            this.comboBoxGymtime.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mobile No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Membership time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Current weight";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Joined date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gym time";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(312, 397);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(424, 397);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(427, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Target weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(294, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 34);
            this.label11.TabIndex = 24;
            this.label11.Text = "Best Fitness";
            // 
            // txttargetweight
            // 
            this.txttargetweight.Location = new System.Drawing.Point(565, 128);
            this.txttargetweight.Name = "txttargetweight";
            this.txttargetweight.Size = new System.Drawing.Size(166, 22);
            this.txttargetweight.TabIndex = 25;
            // 
            // lbl_rbtn
            // 
            this.lbl_rbtn.AutoSize = true;
            this.lbl_rbtn.Location = new System.Drawing.Point(336, 167);
            this.lbl_rbtn.Name = "lbl_rbtn";
            this.lbl_rbtn.Size = new System.Drawing.Size(51, 16);
            this.lbl_rbtn.TabIndex = 32;
            this.lbl_rbtn.Text = "label14";
            this.lbl_rbtn.Visible = false;
            // 
            // numericcoaching
            // 
            this.numericcoaching.Location = new System.Drawing.Point(565, 268);
            this.numericcoaching.Name = "numericcoaching";
            this.numericcoaching.Size = new System.Drawing.Size(120, 22);
            this.numericcoaching.TabIndex = 37;
            this.numericcoaching.ValueChanged += new System.EventHandler(this.numericcoaching_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Private coaching";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(448, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Swimming";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(448, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Sauna";
            // 
            // numericsauna
            // 
            this.numericsauna.Location = new System.Drawing.Point(565, 310);
            this.numericsauna.Name = "numericsauna";
            this.numericsauna.Size = new System.Drawing.Size(120, 22);
            this.numericsauna.TabIndex = 41;
            // 
            // numericswimming
            // 
            this.numericswimming.Location = new System.Drawing.Point(565, 349);
            this.numericswimming.Name = "numericswimming";
            this.numericswimming.Size = new System.Drawing.Size(120, 22);
            this.numericswimming.TabIndex = 42;
            // 
            // new_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 532);
            this.Controls.Add(this.numericswimming);
            this.Controls.Add(this.numericsauna);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericcoaching);
            this.Controls.Add(this.lbl_rbtn);
            this.Controls.Add(this.txttargetweight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGymtime);
            this.Controls.Add(this.comboBoxMembership);
            this.Controls.Add(this.dateTimePickerJoindate);
            this.Controls.Add(this.currentweight);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.txtSecondname);
            this.Controls.Add(this.txtFirstname);
            this.DoubleBuffered = true;
            this.Name = "new_member";
            this.Text = "Newmember";
            this.Load += new System.EventHandler(this.new_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericcoaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsauna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericswimming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtSecondname;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox currentweight;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoindate;
        private System.Windows.Forms.ComboBox comboBoxMembership;
        private System.Windows.Forms.ComboBox comboBoxGymtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttargetweight;
        internal System.Windows.Forms.Label lbl_rbtn;
        private System.Windows.Forms.NumericUpDown numericcoaching;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericsauna;
        private System.Windows.Forms.NumericUpDown numericswimming;
    }
}