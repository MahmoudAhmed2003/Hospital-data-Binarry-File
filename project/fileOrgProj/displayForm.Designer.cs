namespace fileOrgProj
{
    partial class displayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.displayTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(163, 365);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 45);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.displayBtn.CausesValidation = false;
            this.displayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayBtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayBtn.Location = new System.Drawing.Point(614, 345);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(122, 53);
            this.displayBtn.TabIndex = 12;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.displayTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTxtBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxtBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayTxtBox.Location = new System.Drawing.Point(12, 12);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.Size = new System.Drawing.Size(766, 327);
            this.displayTxtBox.TabIndex = 13;
            this.displayTxtBox.Text = "";
            this.displayTxtBox.TextChanged += new System.EventHandler(this.displayTxtBox_TextChanged);
            // 
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTxtBox);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "displayForm";
            this.Text = "displayForm";
            this.Load += new System.EventHandler(this.displayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.RichTextBox displayTxtBox;
    }
}