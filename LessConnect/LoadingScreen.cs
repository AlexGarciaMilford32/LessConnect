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

namespace LessConnect
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {

           

            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;


        }
        private void Continue()
        {
            
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            loadpercentlabel.Text = e.ProgressPercentage.ToString()  + "%";

            if(progressBar1.Value == 100)
            {
                this.Close();
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i <= 100; i ++, random.Next(0, 100))
            {
                Thread.Sleep(random.Next(0, 250));
                backgroundWorker1.ReportProgress(i);

              


            }
            
            Continue();
            
        }

        private void bypassbutton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            versionlabel.Text += Form1.GLOBAL_VER;
            // backgroundWorker1.RunWorkerAsync();

          

            // this.Close();



        }

        private void StartVerify_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }
    }
}
