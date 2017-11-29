using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.Net;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;

namespace LessConnect_Activate_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void CodeBox_TextChanged(object sender, EventArgs e)
        {
            if (CodeBox.TextLength < 8)
            {
                ActivateButton.Enabled = false;
            }
            else
            {
                ActivateButton.Enabled = true;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateButton.Enabled = false;
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            //https://drive.google.com/uc?export=download&id=1Ef26zRdX0M1LHeE3MQoSWkXQiVd1-AOA
            WebBrowser MyWeb = new WebBrowser();

            string ACTIVATIONKEY;

            // MyWeb.Url = new Uri("https://drive.google.com/uc?export=download&id=1Ef26zRdX0M1LHeE3MQoSWkXQiVd1-AOA");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://drive.google.com/uc?export=download&id=1Ef26zRdX0M1LHeE3MQoSWkXQiVd1-AOA", "ActivationKey.card");
            AES_Decrypt("ActivationKey.card", "ActivationKey.txt", CodeBox.Text);

            StreamReader file = new StreamReader("ActivationKey.txt");
            ACTIVATIONKEY = file.ReadLine();
            
            file.Close();
            File.Delete("ActivationKey.txt");
            File.Delete("ActivationKey.card");

            string INPUTCODE;
            INPUTCODE = CodeBox.Text;


            if (ACTIVATIONKEY != INPUTCODE)
            {
                AES_Decrypt("LessConnect.card", "LessConnect.exe", CodeBox.Text);
                MessageBox.Show("You have Seccesfully Licensed LessConnect!");
                Process.Start("LessConnect.exe");
                Application.Exit();
            }
            else
            {
               
            }

    



        }





        private static void AES_Decrypt(string inputFile, string outputFile, string passwordBytes)
        {

            try
            {

                byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged AES = new RijndaelManaged();

                AES.KeySize = 256;
                AES.BlockSize = 128;


                var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.Zeros;

                AES.Mode = CipherMode.CBC;

                CryptoStream cs = new CryptoStream(fsCrypt,
                    AES.CreateDecryptor(),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("There was an error unpacking the file: Error Code (1)");
            }

        }






    }
}
