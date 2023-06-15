namespace fileOrgProj
{
    partial class search
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
            this.idTxtBox = new System.Windows.Forms.RichTextBox();
            this.codeLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.displayTxtBox = new System.Windows.Forms.RichTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTxtBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBox.Location = new System.Drawing.Point(27, 27);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(310, 53);
            this.idTxtBox.TabIndex = 0;
            this.idTxtBox.Text = "";
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.BackColor = System.Drawing.Color.Transparent;
            this.codeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.codeLbl.Location = new System.Drawing.Point(378, 36);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(62, 33);
            this.codeLbl.TabIndex = 1;
            this.codeLbl.Text = "Code";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.Location = new System.Drawing.Point(552, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 44);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.displayTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTxtBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxtBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayTxtBox.Location = new System.Drawing.Point(27, 105);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.Size = new System.Drawing.Size(638, 188);
            this.displayTxtBox.TabIndex = 3;
            this.displayTxtBox.Text = "";
            this.displayTxtBox.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::fileOrgProj.Properties.Resources.backBtnIconWh;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(187, 362);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 52);
            this.backBtn.TabIndex = 4;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fileOrgProj.Properties.Resources.mainBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.displayTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.idTxtBox);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox idTxtBox;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RichTextBox displayTxtBox;
        private System.Windows.Forms.Button backBtn;
    }
}