using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LessAPI;
using LessConnect.Recources;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using LessConnect.Project_Something_New;
using LessConnect.Recources;

namespace LessConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //start background worker ProjectSomethingNew
            backgroundWorker1.DoWork += SomethingNewReision1.StartSomethingNewService_DoWork;
           // backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker2.DoWork += SomethingNewRevision2.StartSomethingNewRev2_DoWork;

            //backgroundWorker4.DoWork += Recources.Logger.StartLogging_DoWork;
           // backgroundWorker4.ProgressChanged += Logging_ProgressChanged;
            //backgroundWorker4.WorkerReportsProgress = true;



        }

        private void Logging_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        //usable strings
        public static string GLOBAL_VER = "0.2.1 Alpha Rev 3";
        public static string NewLine = Environment.NewLine;
        public static string Choice = null;
        public static String LogFile = "ServerLog"+Environment.MachineName+".txt";
        public static string Command = null;
        public static int port = 4525;
        public static string path = "Webpage\\index.html";
        public static string LoggerPath = "LessConnect LogUpload.exe";
        public static string exe = "";
        public static string win32command = "";
        public static string GLOBALIPV4;

        const int PORT_NO = 7000;
       
    

        private void StartButton_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();
            StartButton.Enabled = false;
            StopButton.Enabled = true;

            
          ///TODO Must fix the Log System because it is not showing effective error reporting 


            //DO A System Check
            LogBox.AppendText("Starting System Check..." + NewLine);
            File.AppendAllText("Logs\\" + LogFile, "Starting a System check...    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
            Less.SysCheck(4);
            File.AppendAllText("Logs\\" + LogFile, "System check came back with ("+ LessConnect.Recources.CHECK_SYS.errors + ")" + " Errors!" + "    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
            LogBox.AppendText("System Check Completed!" + NewLine);
            File.AppendAllText("Logs\\" + LogFile, "Starting Server...    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
            LogBox.AppendText("Starting Server..." + NewLine);

            //LogBox.AppendText("Server Started on port " + port + ", Waiting for a respomse..." + NewLine);
           // Less.StartServer(port, path);
            LogBox.AppendText("Server Started on port "+ port + ", Waiting for a respomse..." + NewLine);

            LogBox.AppendText("Server Primed!" + NewLine);
            File.AppendAllText("Logs\\" + LogFile, "Server is primed and ready to go on port "+ port + "     -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);


            // MessageBox.Show("LessConnect Will Be frozen until command is executed, this will be fixed in a later update!", "LessConnect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


           // Process.Start(LoggerPath);


            //Starts Project StartSomethingNewRev2 in a new thread
            backgroundWorker2.RunWorkerAsync();

            //ProjectSomethingNew.StartSomethingNew();
            



           
        }



















        public  void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();
            
            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read   
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the   
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    LogBox.AppendText("Read {0} bytes from socket. \n : {1}");
                    // Echo the data back to the client.  
                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
                string bitesent = "Sent {0} bytes to client.";
                LogBox.AppendText(bitesent);


                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                LogBox.AppendText(e.ToString());
            }


        }



        private void SelectActionButton_Click(object sender, EventArgs e)
        {
      

           
        }

        private void ChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            StartButton.Enabled = true;
           // SERVER_START.StopServer();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SomethingNewRevision2.GetIpV4();
            mACHINENAMEToolStripMenuItem1.Text = Environment.MachineName;
            iPV4ToolStripMenuItem.Text = GLOBALIPV4;
            SomethingNewRevision2.GetExternalIP();
            eXTERNALIPToolStripMenuItem1.Text = SomethingNewRevision2.GLOBAL_EXTERNAL_IP;


            try
            {
                this.Text += GLOBAL_VER;
            }
            catch
            {
                MessageBox.Show("there is something wrong with LessConnect", "LessConnect Error");
            }
           


            StopButton.Enabled = false;

            






            //load settings
            hideAdminToolsAndOptonsToolStripMenuItem.Checked = true;
  
        

            //End Settings
        }

        private void wifibutton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();
        }

 

        private void machineNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Your uniqe Machine name is : " + Environment.MachineName, "LessConnect Help");
        }

        private void uploadLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessConnect.Recources.UPLOAD_LOGS.Upload();
        }

        private void hideAdminToolsAndOptonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideAdminToolsAndOptonsToolStripMenuItem.Checked == true)
            {
               
             
            
               
            }
            else
            {
            
              

            }
        }
        

     



      

        private void listenforcommand_Click(object sender, EventArgs e)
        {

        }

        private void createfunctioncard_Click(object sender, EventArgs e)
        {
            CreateProgramCardSettings CreateForm = new CreateProgramCardSettings();
            CreateForm.ShowDialog();
        }














        // State object for reading client data asynchronously  
        public class StateObject
        {
            // Client  socket.  
            public Socket workSocket = null;
            // Size of receive buffer.  
            public const int BufferSize = 1024;
            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];
            // Received data string.  
            public StringBuilder sb = new StringBuilder();
        }

    
            // Thread signal.  
            public static ManualResetEvent allDone = new ManualResetEvent(false);

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void iPv4AddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LessConnect.Project_Something_New.SomethingNewRevision2.GetIpV4();
           // MessageBox.Show("Your Local IPv4 Address is : " + SomethingNewRevision2.IPv4,"LessConnect Help");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void selectprogramlabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "LessConnect : Locate exe to execute";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|EXE files (*.exe)|*.exe";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                exe = fdlg.FileName;
            }
        }

        private void selectcommand32label_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "LessConnect : Locate Win32 Command file to execute";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|BAT Files (*.bat)|*.bat";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                win32command = fdlg.FileName;
            }
        }

        private void externalIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadLessConnectCustomFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "LessConnect : Locate LessConnect Custom Card";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|LessConnect Card (*.card)|*.card";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                win32command = fdlg.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void whatsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changelog for version : " + GLOBAL_VER + NewLine +
                "Changes/Additions:" + NewLine +
                "- Added Loading Screen and progress to be Loaded" + NewLine +
                "- Added a ChangeLog (this) TODO Improve" + NewLine + 
                "- Added Graphics to the new loading screen and Home screen"+ NewLine+
                "- Added an About dialog about LessConnect" + NewLine + 
                "- Added a list of available actions (Two of wich are selectable and modifyable (the start a program and win32comamnd))" + NewLine + 
                "- Added the \"Message : \" Command so you can send the server messages and display them from your client TODO Make a client"
                 
                
                
                
                
                ,"LessConnect Changelog");
        }

        private void aboutLessConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
