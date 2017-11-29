using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services.Description;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using LessConnect;

namespace LessConnect.Project_Something_New
{
    class SomethingNewRevision2
    {

        //GLOBAL String for IP
        public static string IPv4;
        public static string GLOBAL_EXTERNAL_IP;
        public static int port_Global = 4525;


        //Global Data Recieved
        public static string RecievedDATA;
        public static byte[] data;



        //Get Applications Global IP
        public static void GetIpV4()
        {
            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP4Address = IPA.ToString();
                    IPv4 = IP4Address.ToString();
                    Form1.GLOBALIPV4 = IP4Address.ToString();
                    /*
                    I have the break commented off because i was getting a different IP than my actuall IPv4 Address so i removed it to give me the 
                    one furthest down and to see if that would do it and it did!
                 */

                    //break;
                }
            }
        }




        public static void GetExternalIP()
        {
            Form1.LogBox.AppendText("External IP is : " + GLOBAL_EXTERNAL_IP);
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            GLOBAL_EXTERNAL_IP = externalip ;

            


           // MessageBox.Show("External Ip : " + GLOBAL_EXTERNAL_IP);
            
        }


        public static void StartSomethingNewRev2_DoWork(object sender, DoWorkEventArgs e)
        {
            GetExternalIP();



            //Start by setting Global IP
            GetIpV4();
            StartServerUDP();


        }




        public static void StartServerUDP()
        {


           
            UdpClient client = null;
            try
            {
              
                Form1.LogBox.AppendText("Starting UDP Serve on port : " + port_Global );
               client = new UdpClient(4525);
          
            }
            catch (Exception ex)
            {
                Form1.LogBox.AppendText("There was an internal error : " + ex.Message);
                //MessageBox.Show(ex.Message,"LessConnect Error!" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            while (true)
            {
                //Old
                IPEndPoint server = new IPEndPoint(IPAddress.Any, port_Global);

                //New
                //IPEndPoint server = new IPEndPoint(IPAddress.Parse(GLOBAL_EXTERNAL_IP), 4525);


                byte[] packet = client.Receive(ref server);
                Console.WriteLine(Encoding.ASCII.GetString(packet));

                Recources.EXECUTION.COMMAND = Encoding.ASCII.GetString(packet);
                    Recources.EXECUTION.execute();
              
                




            }







        }












    }
}
