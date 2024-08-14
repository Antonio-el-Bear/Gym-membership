namespace PRG262_BKV_8
{
    partial class GymManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.btnDisplayMembers = new System.Windows.Forms.Button();
            this.btnDisplayClasses = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInstructorToSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClassInstructor = new System.Windows.Forms.Button();
            this.txtClassDuration = new System.Windows.Forms.TextBox();
            this.txtClassCapacity = new System.Windows.Forms.TextBox();
            this.txtClassSchedule = new System.Windows.Forms.TextBox();
            this.txtClassInstructor = new System.Windows.Forms.TextBox();
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnInsertClass = new System.Windows.Forms.Button();
            this.lblClassProgramDuration = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClassProgramName = new System.Windows.Forms.Label();
            this.lblClassProgramId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnManageMemberRemove = new System.Windows.Forms.Button();
            this.btnManageMemberDelete = new System.Windows.Forms.Button();
            this.btnManageMemberUpdate = new System.Windows.Forms.Button();
            this.btnManageMemberInsert = new System.Windows.Forms.Button();
            this.dtpMemberEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMemberStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemberTrainingProgram = new System.Windows.Forms.TextBox();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.txtMemberPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbMemberGender = new System.Windows.Forms.ComboBox();
            this.dtpMemberDOB = new System.Windows.Forms.DateTimePicker();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.txtMemberFirstName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnOpenNewUserForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMembers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMembers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMembers.Location = new System.Drawing.Point(12, 60);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(753, 375);
            this.dgMembers.TabIndex = 1;
            this.dgMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMembers_CellClick);
            // 
            // btnDisplayMembers
            // 
            this.btnDisplayMembers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayMembers.Location = new System.Drawing.Point(215, 3);
            this.btnDisplayMembers.Name = "btnDisplayMembers";
            this.btnDisplayMembers.Size = new System.Drawing.Size(195, 42);
            this.btnDisplayMembers.TabIndex = 2;
            this.btnDisplayMembers.Text = "Display Gym Members";
            this.btnDisplayMembers.UseVisualStyleBackColor = true;
            this.btnDisplayMembers.Click += new System.EventHandler(this.btnDisplayMembers_Click);
            // 
            // btnDisplayClasses
            // 
            this.btnDisplayClasses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayClasses.Location = new System.Drawing.Point(12, 3);
            this.btnDisplayClasses.Name = "btnDisplayClasses";
            this.btnDisplayClasses.Size = new System.Drawing.Size(197, 41);
            this.btnDisplayClasses.TabIndex = 3;
            this.btnDisplayClasses.Text = "Display Class/Programs";
            this.btnDisplayClasses.UseVisualStyleBackColor = true;
            this.btnDisplayClasses.Click += new System.EventHandler(this.btnDisplayClasses_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(771, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 426);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtInstructorToSearch);
            this.tabPage1.Controls.Add(this.btnSearchClassInstructor);
            this.tabPage1.Controls.Add(this.txtClassDuration);
            this.tabPage1.Controls.Add(this.txtClassCapacity);
            this.tabPage1.Controls.Add(this.txtClassSchedule);
            this.tabPage1.Controls.Add(this.txtClassInstructor);
            this.tabPage1.Controls.Add(this.txtClassDescription);
            this.tabPage1.Controls.Add(this.txtClassName);
            this.tabPage1.Controls.Add(this.txtClassID);
            this.tabPage1.Controls.Add(this.btnClassUpdate);
            this.tabPage1.Controls.Add(this.btnClassDelete);
            this.tabPage1.Controls.Add(this.btnInsertClass);
            this.tabPage1.Controls.Add(this.lblClassProgramDuration);
            this.tabPage1.Controls.Add(this.lblCapacity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblClassProgramName);
            this.tabPage1.Controls.Add(this.lblClassProgramId);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Class / Training Program";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 21);
            this.label14.TabIndex = 40;
            this.label14.Text = "Search By Instructor:";
            // 
            // txtInstructorToSearch
            // 
            this.txtInstructorToSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructorToSearch.Location = new System.Drawing.Point(205, 334);
            this.txtInstructorToSearch.Name = "txtInstructorToSearch";
            this.txtInstructorToSearch.Size = new System.Drawing.Size(127, 29);
            this.txtInstructorToSearch.TabIndex = 39;
            this.txtInstructorToSearch.Text = "instructor name";
            // 
            // btnSearchClassInstructor
            // 
            this.btnSearchClassInstructor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClassInstructor.Location = new System.Drawing.Point(335, 330);
            this.btnSearchClassInstructor.Name = "btnSearchClassInstructor";
            this.btnSearchClassInstructor.Size = new System.Drawing.Size(87, 35);
            this.btnSearchClassInstructor.TabIndex = 38;
            this.btnSearchClassInstructor.Text = "Search Instructor";
            this.btnSearchClassInstructor.UseVisualStyleBackColor = true;
            this.btnSearchClassInstructor.Click += new System.EventHandler(this.btnSearchClassInstructor_Click_1);
            // 
            // txtClassDuration
            // 
            this.txtClassDuration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassDuration.Location = new System.Drawing.Point(134, 231);
            this.txtClassDuration.Name = "txtClassDuration";
            this.txtClassDuration.Size = new System.Drawing.Size(253, 26);
            this.txtClassDuration.TabIndex = 37;
            // 
            // txtClassCapacity
            // 
            this.txtClassCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassCapacity.Location = new System.Drawing.Point(134, 196);
            this.txtClassCapacity.Name = "txtClassCapacity";
            this.txtClassCapacity.Size = new System.Drawing.Size(253, 26);
            this.txtClassCapacity.TabIndex = 36;
            // 
            // txtClassSchedule
            // 
            this.txtClassSchedule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassSchedule.Location = new System.Drawing.Point(134, 163);
            this.txtClassSchedule.Name = "txtClassSchedule";
            this.txtClassSchedule.Size = new System.Drawing.Size(253, 26);
            this.txtClassSchedule.TabIndex = 35;
            // 
            // txtClassInstructor
            // 
            this.txtClassInstructor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassInstructor.Location = new System.Drawing.Point(134, 129);
            this.txtClassInstructor.Name = "txtClassInstructor";
            this.txtClassInstructor.Size = new System.Drawing.Size(253, 26);
            this.txtClassInstructor.TabIndex = 34;
            // 
            // txtClassDescription
            // 
            this.txtClassDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassDescription.Location = new System.Drawing.Point(134, 94);
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.Size = new System.Drawing.Size(253, 26);
            this.txtClassDescription.TabIndex = 33;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(186, 58);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(201, 26);
            this.txtClassName.TabIndex = 32;
            // 
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(186, 23);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(201, 26);
            this.txtClassID.TabIndex = 31;
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassUpdate.Location = new System.Drawing.Point(272, 277);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnClassUpdate.TabIndex = 29;
            this.btnClassUpdate.Text = "Update";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassDelete.Location = new System.Drawing.Point(191, 277);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(75, 34);
            this.btnClassDelete.TabIndex = 28;
            this.btnClassDelete.Text = "Delete";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click_1);
            // 
            // btnInsertClass
            // 
            this.btnInsertClass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertClass.Location = new System.Drawing.Point(110, 277);
            this.btnInsertClass.Name = "btnInsertClass";
            this.btnInsertClass.Size = new System.Drawing.Size(75, 34);
            this.btnInsertClass.TabIndex = 27;
            this.btnInsertClass.Text = "Insert";
            this.btnInsertClass.UseVisualStyleBackColor = true;
            this.btnInsertClass.Click += new System.EventHandler(this.btnInsertClass_Click_1);
            // 
            // lblClassProgramDuration
            // 
            this.lblClassProgramDuration.AutoSize = true;
            this.lblClassProgramDuration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassProgramDuration.Location = new System.Drawing.Point(39, 234);
            this.lblClassProgramDuration.Name = "lblClassProgramDuration";
            this.lblClassProgramDuration.Size = new System.Drawing.Size(78, 21);
            this.lblClassProgramDuration.TabIndex = 26;
            this.lblClassProgramDuration.Text = "Duration:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(37, 199);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(80, 21);
            this.lblCapacity.TabIndex = 25;
            this.lblCapacity.Text = "Capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Shedule:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Instructor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Description:";
            // 
            // lblClassProgramName
            // 
            this.lblClassProgramName.AutoSize = true;
            this.lblClassProgramName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassProgramName.Location = new System.Drawing.Point(18, 61);
            this.lblClassProgramName.Name = "lblClassProgramName";
            this.lblClassProgramName.Size = new System.Drawing.Size(172, 21);
            this.lblClassProgramName.TabIndex = 21;
            this.lblClassProgramName.Text = "Class/Program Name:";
            // 
            // lblClassProgramId
            // 
            this.lblClassProgramId.AutoSize = true;
            this.lblClassProgramId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassProgramId.Location = new System.Drawing.Point(18, 26);
            this.lblClassProgramId.Name = "lblClassProgramId";
            this.lblClassProgramId.Size = new System.Drawing.Size(148, 21);
            this.lblClassProgramId.TabIndex = 20;
            this.lblClassProgramId.Text = "Class/Program ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btnManageMemberRemove);
            this.tabPage2.Controls.Add(this.btnManageMemberDelete);
            this.tabPage2.Controls.Add(this.btnManageMemberUpdate);
            this.tabPage2.Controls.Add(this.btnManageMemberInsert);
            this.tabPage2.Controls.Add(this.dtpMemberEndDate);
            this.tabPage2.Controls.Add(this.dtpMemberStartDate);
            this.tabPage2.Controls.Add(this.txtMemberTrainingProgram);
            this.tabPage2.Controls.Add(this.txtMemberAddress);
            this.tabPage2.Controls.Add(this.txtMemberPhoneNumber);
            this.tabPage2.Controls.Add(this.cmbMemberGender);
            this.tabPage2.Controls.Add(this.dtpMemberDOB);
            this.tabPage2.Controls.Add(this.txtMemberLastName);
            this.tabPage2.Controls.Add(this.txtMemberFirstName);
            this.tabPage2.Controls.Add(this.txtMemberID);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Members";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnManageMemberRemove
            // 
            this.btnManageMemberRemove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMemberRemove.Location = new System.Drawing.Point(331, 349);
            this.btnManageMemberRemove.Name = "btnManageMemberRemove";
            this.btnManageMemberRemove.Size = new System.Drawing.Size(109, 33);
            this.btnManageMemberRemove.TabIndex = 47;
            this.btnManageMemberRemove.Text = "Remove All";
            this.btnManageMemberRemove.UseVisualStyleBackColor = true;
            this.btnManageMemberRemove.Visible = false;
            this.btnManageMemberRemove.Click += new System.EventHandler(this.btnManageMemberRemove_Click);
            // 
            // btnManageMemberDelete
            // 
            this.btnManageMemberDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMemberDelete.Location = new System.Drawing.Point(252, 350);
            this.btnManageMemberDelete.Name = "btnManageMemberDelete";
            this.btnManageMemberDelete.Size = new System.Drawing.Size(75, 33);
            this.btnManageMemberDelete.TabIndex = 45;
            this.btnManageMemberDelete.Text = "Delete";
            this.btnManageMemberDelete.UseVisualStyleBackColor = true;
            this.btnManageMemberDelete.Click += new System.EventHandler(this.btnManageMemberDelete_Click);
            // 
            // btnManageMemberUpdate
            // 
            this.btnManageMemberUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMemberUpdate.Location = new System.Drawing.Point(171, 349);
            this.btnManageMemberUpdate.Name = "btnManageMemberUpdate";
            this.btnManageMemberUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnManageMemberUpdate.TabIndex = 44;
            this.btnManageMemberUpdate.Text = "Update";
            this.btnManageMemberUpdate.UseVisualStyleBackColor = true;
            this.btnManageMemberUpdate.Click += new System.EventHandler(this.btnManageMemberUpdate_Click);
            // 
            // btnManageMemberInsert
            // 
            this.btnManageMemberInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMemberInsert.Location = new System.Drawing.Point(90, 349);
            this.btnManageMemberInsert.Name = "btnManageMemberInsert";
            this.btnManageMemberInsert.Size = new System.Drawing.Size(75, 34);
            this.btnManageMemberInsert.TabIndex = 43;
            this.btnManageMemberInsert.Text = "Insert";
            this.btnManageMemberInsert.UseVisualStyleBackColor = true;
            this.btnManageMemberInsert.Click += new System.EventHandler(this.btnManageMemberInsert_Click);
            // 
            // dtpMemberEndDate
            // 
            this.dtpMemberEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMemberEndDate.Location = new System.Drawing.Point(183, 318);
            this.dtpMemberEndDate.Name = "dtpMemberEndDate";
            this.dtpMemberEndDate.Size = new System.Drawing.Size(223, 26);
            this.dtpMemberEndDate.TabIndex = 42;
            // 
            // dtpMemberStartDate
            // 
            this.dtpMemberStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMemberStartDate.Location = new System.Drawing.Point(182, 289);
            this.dtpMemberStartDate.Name = "dtpMemberStartDate";
            this.dtpMemberStartDate.Size = new System.Drawing.Size(223, 26);
            this.dtpMemberStartDate.TabIndex = 41;
            // 
            // txtMemberTrainingProgram
            // 
            this.txtMemberTrainingProgram.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberTrainingProgram.Location = new System.Drawing.Point(140, 254);
            this.txtMemberTrainingProgram.Name = "txtMemberTrainingProgram";
            this.txtMemberTrainingProgram.Size = new System.Drawing.Size(262, 26);
            this.txtMemberTrainingProgram.TabIndex = 40;
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberAddress.Location = new System.Drawing.Point(122, 220);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(280, 26);
            this.txtMemberAddress.TabIndex = 39;
            // 
            // txtMemberPhoneNumber
            // 
            this.txtMemberPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPhoneNumber.Location = new System.Drawing.Point(122, 188);
            this.txtMemberPhoneNumber.Name = "txtMemberPhoneNumber";
            this.txtMemberPhoneNumber.Size = new System.Drawing.Size(280, 26);
            this.txtMemberPhoneNumber.TabIndex = 38;
            // 
            // cmbMemberGender
            // 
            this.cmbMemberGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemberGender.FormattingEnabled = true;
            this.cmbMemberGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbMemberGender.Location = new System.Drawing.Point(122, 154);
            this.cmbMemberGender.Name = "cmbMemberGender";
            this.cmbMemberGender.Size = new System.Drawing.Size(280, 27);
            this.cmbMemberGender.TabIndex = 37;
            // 
            // dtpMemberDOB
            // 
            this.dtpMemberDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMemberDOB.Location = new System.Drawing.Point(122, 125);
            this.dtpMemberDOB.Name = "dtpMemberDOB";
            this.dtpMemberDOB.Size = new System.Drawing.Size(280, 26);
            this.dtpMemberDOB.TabIndex = 36;
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberLastName.Location = new System.Drawing.Point(103, 88);
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(299, 26);
            this.txtMemberLastName.TabIndex = 35;
            // 
            // txtMemberFirstName
            // 
            this.txtMemberFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFirstName.Location = new System.Drawing.Point(103, 52);
            this.txtMemberFirstName.Name = "txtMemberFirstName";
            this.txtMemberFirstName.Size = new System.Drawing.Size(298, 26);
            this.txtMemberFirstName.TabIndex = 34;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(102, 18);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(299, 26);
            this.txtMemberID.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-2, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "Membership End Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-4, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Membership Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Training Program:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "MemberID:";
            // 
            // btnDisplayUsers
            // 
            this.btnDisplayUsers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayUsers.Location = new System.Drawing.Point(416, 4);
            this.btnDisplayUsers.Name = "btnDisplayUsers";
            this.btnDisplayUsers.Size = new System.Drawing.Size(195, 42);
            this.btnDisplayUsers.TabIndex = 7;
            this.btnDisplayUsers.Text = "Display Users";
            this.btnDisplayUsers.UseVisualStyleBackColor = true;
            this.btnDisplayUsers.Click += new System.EventHandler(this.btnDisplayUsers_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(617, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.btnOpenNewUserForm);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(446, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create User";
            // 
            // btnOpenNewUserForm
            // 
            this.btnOpenNewUserForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNewUserForm.Location = new System.Drawing.Point(24, 20);
            this.btnOpenNewUserForm.Name = "btnOpenNewUserForm";
            this.btnOpenNewUserForm.Size = new System.Drawing.Size(169, 43);
            this.btnOpenNewUserForm.TabIndex = 0;
            this.btnOpenNewUserForm.Text = "Create New User";
            this.btnOpenNewUserForm.UseVisualStyleBackColor = true;
            this.btnOpenNewUserForm.Click += new System.EventHandler(this.btnOpenNewUserForm_Click);
            // 
            // GymManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisplayUsers);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDisplayClasses);
            this.Controls.Add(this.btnDisplayMembers);
            this.Controls.Add(this.dgMembers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GymManagementForm";
            this.Text = "GymManagementForm";
            this.Load += new System.EventHandler(this.GymManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Button btnDisplayMembers;
        private System.Windows.Forms.Button btnDisplayClasses;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtInstructorToSearch;
        private System.Windows.Forms.Button btnSearchClassInstructor;
        private System.Windows.Forms.TextBox txtClassDuration;
        private System.Windows.Forms.TextBox txtClassCapacity;
        private System.Windows.Forms.TextBox txtClassSchedule;
        private System.Windows.Forms.TextBox txtClassInstructor;
        private System.Windows.Forms.TextBox txtClassDescription;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnInsertClass;
        private System.Windows.Forms.Label lblClassProgramDuration;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClassProgramName;
        private System.Windows.Forms.Label lblClassProgramId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnManageMemberDelete;
        private System.Windows.Forms.Button btnManageMemberUpdate;
        private System.Windows.Forms.Button btnManageMemberInsert;
        private System.Windows.Forms.DateTimePicker dtpMemberEndDate;
        private System.Windows.Forms.DateTimePicker dtpMemberStartDate;
        private System.Windows.Forms.TextBox txtMemberTrainingProgram;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.TextBox txtMemberPhoneNumber;
        private System.Windows.Forms.ComboBox cmbMemberGender;
        private System.Windows.Forms.DateTimePicker dtpMemberDOB;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.TextBox txtMemberFirstName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnManageMemberRemove;
        private System.Windows.Forms.Button btnDisplayUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOpenNewUserForm;
    }
}