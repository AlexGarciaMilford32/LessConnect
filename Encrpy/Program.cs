using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrpy
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string inputfile = "";
            string outputfile = inputfile + ".card";

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                string choice;
                choice = Console.ReadLine();
                if (choice == "encrypt")
                {
                    OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                    // Show the dialog and get result.



                    string fileName;
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.ShowDialog();
                    inputfile = fd.FileName;
                    Console.WriteLine(inputfile);
                    Console.WriteLine("What do you want the outputfilename be? ");
                    string newoutputname = "";
                    newoutputname = Console.ReadLine();
                    AES_Encrypt(inputfile, newoutputname, "LESS-0105-AqWz-!2#P-PPQZ");
                }
                if (choice == "decrypt")
                {
                    OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                    // Show the dialog and get result.



                    string fileName;
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.ShowDialog();
                    inputfile = fd.FileName;
                    Console.WriteLine(inputfile);
                    Console.WriteLine("What do you want the outputfilename be? ");
                    string newoutputname = "";
                    newoutputname = Console.ReadLine();
                    AES_Decrypt(inputfile, newoutputname, "LESS-0105-AqWz-!2#P-PPQZ");
                }

            }









        }


        private static void AES_Encrypt(string inputFile, string outputFile, string passwordBytes)
        {
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 ,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt,
                 AES.CreateEncryptor(),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();



        }



        private static void AES_Decrypt(string inputFile, string outputFile, string passwordBytes)
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
    }

}

