using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LessConnect.Recources
{
    class EXECUTION
    {
        public static string TODO = null;
        public static string PROCESS = null;
        public static string COMMAND = null;
        public static void execute()
        {




            if (COMMAND == "hi")
            {
                MessageBox.Show("You said hello from a IP address");
            }



            if (COMMAND == "testresponse")
            {
                MessageBox.Show("This is a test response!","LessConnect");
            }
                
                if (COMMAND == "Start a Program")
                {
                    Process.Start(Form1.exe);
                }
                if (COMMAND == "Say Hello")
                {
                    MessageBox.Show("Hello, from Alex Garcia");
                }
                if (COMMAND == "Win32 Command")
                {
                    StreamWriter q = new StreamWriter("command.bat");
                    q.WriteLine(COMMAND);
                    q.Close();
                    Process.Start("command.bat");
                    
                }

                if (COMMAND == "Kill")
                {
                    Application.Exit();
            }
                  if (COMMAND == "Restart")
                     {
                    Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                    Application.Exit();
                  }
            if (COMMAND.Contains("Message :"))
            {
                MessageBox.Show("You have been sent a message." + Environment.NewLine + COMMAND ,"LessConnect Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }




      
            
            
        }
    }
}
