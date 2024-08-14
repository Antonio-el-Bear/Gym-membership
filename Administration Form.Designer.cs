namespace PRG262_BKV_8
{
    partial class Administration_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageClasses = new System.Windows.Forms.Button();
            this.dgAdminView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnManageMembers);
            this.groupBox1.Controls.Add(this.btnManageClasses);
            this.groupBox1.Location = new System.Drawing.Point(529, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage Users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Location = new System.Drawing.Point(6, 48);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(223, 23);
            this.btnManageMembers.TabIndex = 1;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = true;
            // 
            // btnManageClasses
            // 
            this.btnManageClasses.Location = new System.Drawing.Point(6, 19);
            this.btnManageClasses.Name = "btnManageClasses";
            this.btnManageClasses.Size = new System.Drawing.Size(223, 23);
            this.btnManageClasses.TabIndex = 1;
            this.btnManageClasses.Text = "Manage Classes / Training Programs";
            this.btnManageClasses.UseVisualStyleBackColor = true;
            // 
            // dgAdminView
            // 
            this.dgAdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdminView.Location = new System.Drawing.Point(12, 17);
            this.dgAdminView.Name = "dgAdminView";
            this.dgAdminView.Size = new System.Drawing.Size(500, 378);
            this.dgAdminView.TabIndex = 2;
            // 
            // Administration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgAdminView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administration_Form";
            this.Text = "Administration_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageClasses;
        private System.Windows.Forms.DataGridView dgAdminView;
    }
}