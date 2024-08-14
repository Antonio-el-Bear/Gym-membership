namespace PRG262_BKV_8
{
    partial class FrmGymLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUnlockApp = new System.Windows.Forms.Button();
            this.tmrCheckLocked = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(134, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(109, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 32);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(109, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 32);
            this.txtPassword.TabIndex = 4;
            // 
            // btnUnlockApp
            // 
            this.btnUnlockApp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockApp.Location = new System.Drawing.Point(298, 10);
            this.btnUnlockApp.Name = "btnUnlockApp";
            this.btnUnlockApp.Size = new System.Drawing.Size(98, 69);
            this.btnUnlockApp.TabIndex = 5;
            this.btnUnlockApp.Text = "Unlock";
            this.btnUnlockApp.UseVisualStyleBackColor = true;
            this.btnUnlockApp.Visible = false;
            this.btnUnlockApp.Click += new System.EventHandler(this.btnUnlockApp_Click);
            // 
            // tmrCheckLocked
            // 
            this.tmrCheckLocked.Enabled = true;
            this.tmrCheckLocked.Interval = 1000;
            this.tmrCheckLocked.Tick += new System.EventHandler(this.tmrCheckLocked_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(298, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmGymLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 127);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnlockApp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGymLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form Gym Management Application";
            this.Load += new System.EventHandler(this.FrmGymLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUnlockApp;
        private System.Windows.Forms.Timer tmrCheckLocked;
        private System.Windows.Forms.Button btnExit;
    }
}

