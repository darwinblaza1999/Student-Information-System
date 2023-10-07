namespace Information_System
{
    partial class frmUpdatePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(113, 28);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(152, 20);
            this.txtUname.TabIndex = 1;
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(184, 120);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(81, 23);
            this.btnUpdateAcc.TabIndex = 2;
            this.btnUpdateAcc.Text = "&Update";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // txtNewpass
            // 
            this.txtNewpass.Location = new System.Drawing.Point(113, 54);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.Size = new System.Drawing.Size(152, 20);
            this.txtNewpass.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "New Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(113, 80);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmPass.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm password:";
            // 
            // frmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 155);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdatePassword";
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.frmUpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label2;
    }
}