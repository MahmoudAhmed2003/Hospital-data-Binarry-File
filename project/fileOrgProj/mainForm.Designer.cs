namespace fileOrgProj
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Patientmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.testBtnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.delFileBtn = new System.Windows.Forms.Button();
            this.wellcomeLabel = new System.Windows.Forms.Label();
            this.fileNameTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Patientmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFileToolStripMenuItem,
            this.delFileToolStripMenuItem,
            this.exitBtn});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::fileOrgProj.Properties.Resources.fileIcon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(78, 37);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // createNewFileToolStripMenuItem
            // 
            this.createNewFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewFileToolStripMenuItem.Image")));
            this.createNewFileToolStripMenuItem.Name = "createNewFileToolStripMenuItem";
            this.createNewFileToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.createNewFileToolStripMenuItem.Text = "Create New File ";
            this.createNewFileToolStripMenuItem.Click += new System.EventHandler(this.createNewFileToolStripMenuItem_Click);
            // 
            // delFileToolStripMenuItem
            // 
            this.delFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delFileToolStripMenuItem.Image")));
            this.delFileToolStripMenuItem.Name = "delFileToolStripMenuItem";
            this.delFileToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.delFileToolStripMenuItem.Text = "Del File";
            this.delFileToolStripMenuItem.Click += new System.EventHandler(this.delFileToolStripMenuItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 38);
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Patientmenu
            // 
            this.Patientmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientBtn,
            this.modifyPatientBtn,
            this.displayPatientBtn,
            this.searchPatientBtn,
            this.testBtnToolStripMenuItem});
            this.Patientmenu.Image = ((System.Drawing.Image)(resources.GetObject("Patientmenu.Image")));
            this.Patientmenu.Name = "Patientmenu";
            this.Patientmenu.Size = new System.Drawing.Size(117, 37);
            this.Patientmenu.Text = "Patient";
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("addPatientBtn.Image")));
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(288, 38);
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // modifyPatientBtn
            // 
            this.modifyPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("modifyPatientBtn.Image")));
            this.modifyPatientBtn.Name = "modifyPatientBtn";
            this.modifyPatientBtn.Size = new System.Drawing.Size(288, 38);
            this.modifyPatientBtn.Text = "Modify Patient Info";
            this.modifyPatientBtn.Click += new System.EventHandler(this.modifyStudentInfoToolStripMenuItem_Click);
            // 
            // displayPatientBtn
            // 
            this.displayPatientBtn.Image = global::fileOrgProj.Properties.Resources.displayIcon;
            this.displayPatientBtn.Name = "displayPatientBtn";
            this.displayPatientBtn.Size = new System.Drawing.Size(288, 38);
            this.displayPatientBtn.Text = "Display All Patients ";
            this.displayPatientBtn.Click += new System.EventHandler(this.displayPatientBtn_Click);
            // 
            // searchPatientBtn
            // 
            this.searchPatientBtn.Image = global::fileOrgProj.Properties.Resources.search;
            this.searchPatientBtn.Name = "searchPatientBtn";
            this.searchPatientBtn.Size = new System.Drawing.Size(288, 38);
            this.searchPatientBtn.Text = "SearchFor Patient";
            this.searchPatientBtn.Click += new System.EventHandler(this.searchPatientBtn_Click);
            // 
            // testBtnToolStripMenuItem
            // 
            this.testBtnToolStripMenuItem.Image = global::fileOrgProj.Properties.Resources.login;
            this.testBtnToolStripMenuItem.Name = "testBtnToolStripMenuItem";
            this.testBtnToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.testBtnToolStripMenuItem.Text = "Login Page";
            this.testBtnToolStripMenuItem.Click += new System.EventHandler(this.testBtnToolStripMenuItem_Click);
            // 
            // addFileBtn
            // 
            this.addFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.addFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFileBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addFileBtn.Location = new System.Drawing.Point(219, 134);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(136, 52);
            this.addFileBtn.TabIndex = 2;
            this.addFileBtn.Text = "Add File";
            this.addFileBtn.UseVisualStyleBackColor = false;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileNameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fileNameLabel.Location = new System.Drawing.Point(316, 72);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(138, 43);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "File Name";
            this.fileNameLabel.Visible = false;
            this.fileNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // delFileBtn
            // 
            this.delFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.delFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delFileBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFileBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delFileBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.delFileBtn.Location = new System.Drawing.Point(220, 134);
            this.delFileBtn.Name = "delFileBtn";
            this.delFileBtn.Size = new System.Drawing.Size(136, 52);
            this.delFileBtn.TabIndex = 4;
            this.delFileBtn.Text = "Del File";
            this.delFileBtn.UseVisualStyleBackColor = false;
            this.delFileBtn.Click += new System.EventHandler(this.delFileBtn_Click);
            // 
            // wellcomeLabel
            // 
            this.wellcomeLabel.AutoSize = true;
            this.wellcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.wellcomeLabel.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.wellcomeLabel.Location = new System.Drawing.Point(201, 185);
            this.wellcomeLabel.Name = "wellcomeLabel";
            this.wellcomeLabel.Size = new System.Drawing.Size(436, 112);
            this.wellcomeLabel.TabIndex = 5;
            this.wellcomeLabel.Text = "WELLCOME";
            this.wellcomeLabel.Click += new System.EventHandler(this.wellcomeLabel_Click);
            // 
            // fileNameTxtBox
            // 
            this.fileNameTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fileNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameTxtBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTxtBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.fileNameTxtBox.Location = new System.Drawing.Point(26, 60);
            this.fileNameTxtBox.Name = "fileNameTxtBox";
            this.fileNameTxtBox.Size = new System.Drawing.Size(274, 55);
            this.fileNameTxtBox.TabIndex = 6;
            this.fileNameTxtBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileNameTxtBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addFileBtn);
            this.Controls.Add(this.delFileBtn);
            this.Controls.Add(this.wellcomeLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button delFileBtn;
        private System.Windows.Forms.Label wellcomeLabel;
        private System.Windows.Forms.ToolStripMenuItem addPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem modifyPatientBtn;
        public System.Windows.Forms.ToolStripMenuItem Patientmenu;
        private System.Windows.Forms.ToolStripMenuItem displayPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem searchPatientBtn;
        private System.Windows.Forms.RichTextBox fileNameTxtBox;
        private System.Windows.Forms.ToolStripMenuItem testBtnToolStripMenuItem;
    }
}

