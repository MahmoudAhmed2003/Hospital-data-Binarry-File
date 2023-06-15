using fileOrgProj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fileOrgProj
{
    
    
public partial class addPatientForm : Form
    {



        public addPatientForm()
        {
            InitializeComponent();
        }

        private void addPatientForm_Load(object sender, EventArgs e)
        {
            fileNameTxtBox2.Text=info.filename; ;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addpatientBtn_Click(object sender, EventArgs e)
        {



            BinaryWriter bw = new BinaryWriter(File.Open(info.filename, FileMode.Open, FileAccess.Write)); // We Should include using System.IO;
            int length = (int)bw.BaseStream.Length;

            if (length != 0) 
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);

            }
            bw.Write(int.Parse(patientCodeTxtBox.Text)); // ID

            patientNameTxtBox.Text = patientNameTxtBox.Text.PadRight(9); // Name 
            bw.Write(patientNameTxtBox.Text.Substring(0, 9));

            patientPhoneTxtBox.Text = patientPhoneTxtBox.Text.PadRight(11); //Tel 
            bw.Write(patientPhoneTxtBox.Text.Substring(0, 11));

            patientAgeTxtBox.Text = patientAgeTxtBox.Text.PadRight(2);
            bw.Write(patientAgeTxtBox.Text.Substring(0,2)); // age


            length += info.rec_size;
           
          
            patientCodeTxtBox.Clear();
            patientNameTxtBox.Clear();
            patientPhoneTxtBox.Clear();
            patientAgeTxtBox.Clear();
           

            recordNumValue.Text = (length / info.rec_size).ToString(); // update number of records label
            fileSizeValue.Text = length.ToString();//update file length label

            MessageBox.Show(" Data is Saved Successfully ");
            bw.Close();


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }

        private void fileNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recordNumValue_Click(object sender, EventArgs e)
        {

        }

        private void patientNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
