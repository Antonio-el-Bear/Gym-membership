namespace PRG262_BKV_8
{
    partial class frmAdminUnlock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminUnlockUser = new System.Windows.Forms.TextBox();
            this.txtAdminUnlockPass = new System.Windows.Forms.TextBox();
            this.btnAdminUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unlock the program by entering a admin username and password.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Password:";
            // 
            // txtAdminUnlockUser
            // 
            this.txtAdminUnlockUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUnlockUser.Location = new System.Drawing.Point(175, 67);
            this.txtAdminUnlockUser.Name = "txtAdminUnlockUser";
            this.txtAdminUnlockUser.Size = new System.Drawing.Size(172, 26);
            this.txtAdminUnlockUser.TabIndex = 3;
            // 
            // txtAdminUnlockPass
            // 
            this.txtAdminUnlockPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUnlockPass.Location = new System.Drawing.Point(175, 99);
            this.txtAdminUnlockPass.Name = "txtAdminUnlockPass";
            this.txtAdminUnlockPass.PasswordChar = '*';
            this.txtAdminUnlockPass.Size = new System.Drawing.Size(172, 26);
            this.txtAdminUnlockPass.TabIndex = 4;
            // 
            // btnAdminUnlock
            // 
            this.btnAdminUnlock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUnlock.Location = new System.Drawing.Point(175, 128);
            this.btnAdminUnlock.Name = "btnAdminUnlock";
            this.btnAdminUnlock.Size = new System.Drawing.Size(172, 38);
            this.btnAdminUnlock.TabIndex = 5;
            this.btnAdminUnlock.Text = "Unlock";
            this.btnAdminUnlock.UseVisualStyleBackColor = true;
            this.btnAdminUnlock.Click += new System.EventHandler(this.btnAdminUnlock_Click);
            // 
            // frmAdminUnlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 178);
            this.Controls.Add(this.btnAdminUnlock);
            this.Controls.Add(this.txtAdminUnlockPass);
            this.Controls.Add(this.txtAdminUnlockUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminUnlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System Unlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminUnlockUser;
        private System.Windows.Forms.TextBox txtAdminUnlockPass;
        private System.Windows.Forms.Button btnAdminUnlock;
    }
}