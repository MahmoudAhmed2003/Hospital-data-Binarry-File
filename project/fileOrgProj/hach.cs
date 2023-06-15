using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;



namespace fileOrgProj
{
    public partial class hach : Form
    {
        public hach()
        {
            InitializeComponent();
        }
        private string HashPassword(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string user = HashPassword(userTxtBox.Text);
            string pass = HashPassword(passTxtBox.Text);
            File.Create("D:/" + fileNameTxtBox.Text + ".txt").Close();

            BinaryWriter bw = new BinaryWriter(File.Open("D:/" + fileNameTxtBox.Text+".txt", FileMode.Open, FileAccess.Write)); // We Should include using System.IO;
            bw.BaseStream.Seek(0, SeekOrigin.Begin);
            bw.Write(user);
            bw.Write("\t");
            bw.Write(pass);

            bw.Close();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }

        private void hach_Load(object sender, EventArgs e)
        {

        }
    }
}
