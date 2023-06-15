using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileOrgProj
{
    public partial class mainForm : Form
    {
      
        public static bool newFile = false;

        public mainForm()
        {
            InitializeComponent();
        }
        
        

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            
            info.filename = "D:/" + fileNameTxtBox.Text + ".txt";
            if (!File.Exists(info.filename))
            {
                File.Create(info.filename).Close();
                MessageBox.Show("File is Created Successfully", "Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             
                MessageBox.Show("File already exsisting", "Note",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            fileNameTxtBox.Clear();
            mainForm.newFile = true;

            
           
            
            


        }

        private void fileNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void delFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addFileBtn.Visible = false;
            delFileBtn.Visible = true;
            fileNameLabel.Visible = true;
            wellcomeLabel.Visible = false;
            fileNameTxtBox.Visible = true;
            
        }


        private void delFileBtn_Click(object sender, EventArgs e)
        {
            
            info.filename = "D:/" + fileNameTxtBox.Text + ".txt";
            File.Delete(info.filename);
            MessageBox.Show("File is Deleted ");
            fileNameTxtBox.Clear();
            
        }

        private void createNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addFileBtn.Visible = true;
            delFileBtn.Visible = false;
            fileNameLabel.Visible = true;
            wellcomeLabel.Visible = false;
            fileNameTxtBox.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addPatientForm().Show(); 
        } 

        private void delStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void modifyStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new modify().Show();
        }

        private void wellcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayPatientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
          new  displayForm().Show();
        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new search().Show();
        }

        private void testBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new hach().Show();
        }
    }
}
