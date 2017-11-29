using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessConnect
{
    public partial class Form2 : Form
    {
        private bool connect;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                RestartElevated();
            }
        }


        public static bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal p = new WindowsPrincipal(id);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }






        private void hotspotstart_Click_1(object sender, EventArgs e)
        {
            string ssid = "LessConnect WIFI", key = "LESSCONNECT1";
            if (!connect)
            {
                if (textBox1.Text == null || textBox1.Text == "")
                {
                    MessageBox.Show("SSID cannot be left blank !",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (textBox2.Text == null || textBox2.Text == "")
                    {
                        MessageBox.Show("Key value cannot be left blank !",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (key.Length >= 6)
                        {
                            Zedfi_Hotspot(ssid, key, true);
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            hotspotstart.Text = "Stop";
                            connect = true;
                        }
                        else
                        {
                            MessageBox.Show("Key should be more then or Equal to 6 Characters !",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                Zedfi_Hotspot(null, null, false);
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                hotspotstart.Text = "Start";
                connect = false;
            }
        }





        private void Zedfi_Hotspot(string ssid, string key, bool status)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                if (status)
                {
                    process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow   ssid = " + "LessConnectWifi" + " key = " + "LESSCONNECT1");

                    process.StandardInput.WriteLine("netsh wlan start hostednetwork");
                    process.StandardInput.Close();
                }
                else
                {
                    process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
                    process.StandardInput.Close();
                }
            }
        }

        public void RestartElevated()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
            startInfo.Verb = "runas";
            try
            {
                Process p = Process.Start(startInfo);
            }
            catch
            {

            }

            System.Windows.Forms.Application.Exit();
        }

    }
}
