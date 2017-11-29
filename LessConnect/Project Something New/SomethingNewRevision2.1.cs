using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel;
using LessConnect.Recources;
using System.Security.Cryptography;
/*
    This is not a completely new revision of Project SomethingNew,
    this is just a refresh and an update to the current (SomethingNewRevision2)
    
    this may or may not be in the final release. This release is only for trying to 
    fix broadcats problems between interlacing networks that this dose not seem to be enjoying all to much
    
    but the basic fix seems to be to port forward with the server and the thought of it was 
    is to not do that.

    SomethingNewRevision2.1

*/

namespace LessConnect.Project_Something_New
{
    public class DefaultNetValues
    {
        public static string DefaultIP;
        public static int DefaultPort;
        

    }
    
    
    
    
    
    
    public class Pulling
    {
        public static string ParsedIP;
        public static int StartingIP = int.Parse(ParsedIP);
        public static string StartingPort;
        public static string Oem_Label;
        public static void GetNetData()
        {
            //MUST UN ENCRYPT TO GET INFORMATION
            
            
            StreamReader GetNetReader = new StreamReader("LessConnectServerInfo.LessInfo");
           // ParsedIP = GetNetReader.ReadLine();
            StartingPort = (GetNetReader.ReadLine());
            Oem_Label = (GetNetReader.ReadLine());
            //Then after reading card re encrypt it



        }
    }
    
    
    
    
    public class SomethingNewRecources
    {
        //easy way to acces the logbox from Form1
        public static void GlobalLogbox(string input)
        {
            //this will also add a newline
            Form1.LogBox.AppendText(input + Environment.NewLine);
        }
    }
    
    
    public class SomethingNewRevision2_1
    {

        public static void Startup()
        {
            Pulling.GetNetData();
            Form1.toolStripStatusLabel2.Text = "Getting Card File Information... Please Wait...";
            Form1.toolStripStatusLabel2.Text = Pulling.Oem_Label;
            if (Form1.toolStripStatusLabel2.Text == "")
            {
                StartError();
                
                
            }
            
            Form1.LogBox.AppendText("SomethingNew Revision 2.1 Loading" + Environment.NewLine);
            if (File.Exists("LessConnectServerInfo.card"))
            {
                //Do nothing
            }
            else
            {
                try
                {
                    /*
                        Testing Encryption of card File
                    */
                    SomethingNewRecources.GlobalLogbox("Making a Network Card File...");
                    File.Create("lessConnectServerInfo.card");
                    //Adding Default Server Information
                    StreamWriter ServerFile = new StreamWriter("LessConnectServerInfo.LessInfo");
                    //Starting Port
                    ServerFile.WriteLine(4525);
                    ServerFile.WriteLine("OEM Verified BETA");
                    
                    
                    EncryptCardFile("","","");
                    SomethingNewRecources.GlobalLogbox("Network Card File Created Succesfully!");
                }
                catch (Exception e)
                {
                    SomethingNewRecources.GlobalLogbox("There Was a problem Making the Card file for the networking : " + e);
                    
                    throw;
                }
            }

        }
        
        public static void StartError()
        {
            SomethingNewRecources.GlobalLogbox("There Was a problem reading the card file.");
        }
        
        private static void EncryptCardFile(string inputFile, string outputFile, string passwordBytes)
        {
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 ,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            //Original Division of keys is 8 and now testing 24
            AES.Key = key.GetBytes(AES.KeySize / 24);
            AES.IV = key.GetBytes(AES.BlockSize / 24);
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
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }



    public class UDPSocketing
    {
       
        public static void StartUDPServer()
        {
            int UDPErrorCount = 0;
            
            
            
            //ini the UDPClient
            UdpClient Client = null;
            try
            {
                SomethingNewRecources.GlobalLogbox("Starting UDP Server on port : " + SomethingNewRevision2.port_Global.ToString());
                Client = new UdpClient(int.Parse(Pulling.StartingPort));
                
                
                
                
            }
            catch (Exception UDPError)
            {
                SomethingNewRecources.GlobalLogbox("There was an error starting the UDP Server : " + UDPError);
                UDPErrorCount++;
                throw;
            }
            while (UDPErrorCount < 3)
            {
                //TODO Change this mehthod but this is the best thig i have so far
                IPEndPoint UDPServer = new IPEndPoint(IPAddress.Any, SomethingNewRevision2.port_Global);
                byte[] Packet = Client.Receive(ref UDPServer);
                SomethingNewRecources.GlobalLogbox("Command Recieved : " + Encoding.ASCII.GetString(Packet));
                //TODO add a message saying that this is an invalid command to the logbox but i have to do somthing from EXECUTION.cs
            }


        }
                
        
  
    }
  
    
    

    public class Networking
    {
        //this is an open way to get the IPv4
        public static string LocalIPv4;
        //this is an open way to get public external IP
        public static string PublicIP;
        //not accesible 

        //this is the public access to get all networking information because everything is private
        public static void GetNetworkvariables()
        {
            //gets the LocalIPv4
            SetIPv4();
            //gets external IP
            SetPublicIP();
            
        }
        
        private static void SetIPv4()
        {
            

            foreach (IPAddress IP in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    LocalIPv4 = IP.ToString();
                    
                    //this sectoin is only meant for LessConnect Specific Applications
                    //TDOD Add if statement to declare a break on the form 
                    
                }
                
            }

        }
        //TODO Find another way to get the IP other than web string pulling 
        private static void SetPublicIP()
        {
            Form1.LogBox.AppendText("Getting External IP" + Environment.NewLine);
            try
            {
                string ExtIp = new WebClient().DownloadString("http://icanhazip.com");
                PublicIP = ExtIp.ToString();
            }
            catch(Exception exception)
            {
                SomethingNewRecources.GlobalLogbox("There was an error with getting the public IP the error was : " + exception);
            }
     
        }
        
        
        
    }
    
    
    
}