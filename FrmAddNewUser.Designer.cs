namespace PRG262_BKV_8
{
    partial class FrmAddNewUser
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
            this.BtnRegisterNewUser = new System.Windows.Forms.Button();
            this.btnRegisterNewUserCancel = new System.Windows.Forms.Button();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegisterNewUser
            // 
            this.BtnRegisterNewUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegisterNewUser.Location = new System.Drawing.Point(12, 142);
            this.BtnRegisterNewUser.Name = "BtnRegisterNewUser";
            this.BtnRegisterNewUser.Size = new System.Drawing.Size(156, 43);
            this.BtnRegisterNewUser.TabIndex = 0;
            this.BtnRegisterNewUser.Text = "Register New User";
            this.BtnRegisterNewUser.UseVisualStyleBackColor = true;
            this.BtnRegisterNewUser.Click += new System.EventHandler(this.BtnRegisterNewUser_Click);
            // 
            // btnRegisterNewUserCancel
            // 
            this.btnRegisterNewUserCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterNewUserCancel.Location = new System.Drawing.Point(174, 143);
            this.btnRegisterNewUserCancel.Name = "btnRegisterNewUserCancel";
            this.btnRegisterNewUserCancel.Size = new System.Drawing.Size(129, 43);
            this.btnRegisterNewUserCancel.TabIndex = 1;
            this.btnRegisterNewUserCancel.Text = "Cancel";
            this.btnRegisterNewUserCancel.UseVisualStyleBackColor = true;
            this.btnRegisterNewUserCancel.Click += new System.EventHandler(this.btnRegisterNewUserCancel_Click);
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUserName.Location = new System.Drawing.Point(124, 20);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(134, 26);
            this.txtNewUserName.TabIndex = 2;
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUserPassword.Location = new System.Drawing.Point(124, 63);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.Size = new System.Drawing.Size(134, 26);
            this.txtNewUserPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(201, 111);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(70, 23);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.Location = new System.Drawing.Point(118, 111);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(77, 23);
            this.rbUser.TabIndex = 7;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Normal";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Type:";
            // 
            // FrmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewUserPassword);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.btnRegisterNewUserCancel);
            this.Controls.Add(this.BtnRegisterNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewUser";
            this.Text = "Add new user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegisterNewUser;
        private System.Windows.Forms.Button btnRegisterNewUserCancel;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Label label3;
    }
}