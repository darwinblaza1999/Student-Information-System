namespace Information_System
{
    partial class frmUpdateOrDeleteStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboyearlevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudentRegister = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStudentId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStudentId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboyearlevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcourse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStudentRegister);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtmname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 313);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // cboyearlevel
            // 
            this.cboyearlevel.FormattingEnabled = true;
            this.cboyearlevel.Items.AddRange(new object[] {
            "First year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.cboyearlevel.Location = new System.Drawing.Point(116, 241);
            this.cboyearlevel.Name = "cboyearlevel";
            this.cboyearlevel.Size = new System.Drawing.Size(167, 21);
            this.cboyearlevel.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Year level:";
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(116, 215);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(167, 20);
            this.txtcourse.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Course:";
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(116, 189);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(167, 20);
            this.txtConNo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contact Number:";
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Location = new System.Drawing.Point(208, 277);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(75, 23);
            this.btnStudentRegister.TabIndex = 20;
            this.btnStudentRegister.Text = "&Update";
            this.btnStudentRegister.UseVisualStyleBackColor = true;
            this.btnStudentRegister.Click += new System.EventHandler(this.btnStudentRegister_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(116, 56);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(167, 20);
            this.txtfname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(116, 137);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(167, 20);
            this.txtaddress.TabIndex = 11;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(116, 82);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(167, 20);
            this.txtmname.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Middle name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(116, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(167, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(116, 108);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(167, 20);
            this.txtlname.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Student ID:";
            // 
            // cboStudentId
            // 
            this.cboStudentId.FormattingEnabled = true;
            this.cboStudentId.Items.AddRange(new object[] {
            "First year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.cboStudentId.Location = new System.Drawing.Point(116, 25);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(167, 21);
            this.cboStudentId.TabIndex = 28;
            this.cboStudentId.SelectedIndexChanged += new System.EventHandler(this.cboStudentId_SelectedIndexChanged);
            // 
            // frmUpdateOrDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 343);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUpdateOrDeleteStudent";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmUpdateOrDeleteStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboyearlevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudentRegister;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.ComboBox cboStudentId;
        private System.Windows.Forms.Label label6;
    }
}