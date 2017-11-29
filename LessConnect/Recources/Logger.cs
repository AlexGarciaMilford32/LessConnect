using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace LessConnect.Recources
{
    class Logger
    {
        public static void ERROR_MESSAGE()
        {
            MessageBox.Show("Error in Uploading Logs");
      
        }

        public static void StartLogging_DoWork(object sender, DoWorkEventArgs e)
        {
            ReCopy:
            while (true)
            {
                if (Directory.Exists("A:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "A:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;

                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("B:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "B:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("D:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "D:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("E:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "E:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("F:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "F:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("G:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "G:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("H:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "H:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("I:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "I:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("J:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "J:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("K:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "K:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("L:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "L:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("M:\\"))
                {
                    try
                    {

                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "M:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("N:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "N:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("O:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "O:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("P:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "P:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("Q:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "Q:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("R:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "R:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("S:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "S:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("T:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "T:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("U:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "U:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("V:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "V:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("W:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "W:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("X:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "X:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("Y:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "Y:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }
                if (Directory.Exists("Z:\\"))
                {
                    try
                    {
                        File.Copy("Logs\\" + "ServerLog" + Environment.MachineName + ".txt", "Z:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { ERROR_MESSAGE(); }
                }


            }


        }
    }
}
