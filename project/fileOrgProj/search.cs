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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fileOrgProj
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void addpatientBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Visible= true;
            info.rec_count = 0;

            BinaryReader br = new BinaryReader(File.Open(info.filename, FileMode.Open, FileAccess.Read));

            int num_of_records = (int)br.BaseStream.Length / info.rec_size;

            if (num_of_records > 0) // If The file Not Empty
            {
                br.BaseStream.Seek(0, SeekOrigin.Begin); // Move to Specific Position in a File


                for (int i = 0; i < (int)br.BaseStream.Length; i+=info.rec_size)
                {
                    br.BaseStream.Seek(i, SeekOrigin.Begin); // Move to Specific Position in a File

                    int id = br.ReadInt32();
                    if (id == Convert.ToInt32(idTxtBox.Text)) // If ID Matches
                    {
                        displayTxtBox.Text = " ";

                        displayTxtBox.Text += "Name : " + br.ReadString() + "\t"; // Read Name
                        displayTxtBox.Text += "Phone Num : " + br.ReadString() + "\t"; // Read Tel
                        displayTxtBox.Text += " age : " + br.ReadString() + "\t" + "\n"; // Read age



                        break;
                    }

                    else
                    {
                        info.rec_count += info.rec_size; // Move to the next Record                
                    }

                }

            }
            else
            {
                MessageBox.Show("File is Empty");
            }

            br.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }
    }
}
