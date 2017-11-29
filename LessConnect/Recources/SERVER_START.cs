using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessConnect.Recources
{
    class SERVER_START
    {
        public static int calls = 0; //this is for web based call logging used in nigtly builds 
        public static String LogFile = "ServerLog"+Environment.MachineName+".txt";
        public static HttpListener _httpListener = new HttpListener();
        public static String ExternalCommand = null;
        public static void SeverStar(int port, string path)
        {
            try
            {
                
                //Console.WriteLine("Starting server...");
                _httpListener.Prefixes.Add("http://localhost:" + port + "/"); // add prefix "http://localhost:4525/"
                
                _httpListener.Start(); // start server (Run application as Administrator!)
                
                //Console.WriteLine("Server started on port " + port);
                Thread _responseThread = new Thread(ResponseThread);
                _responseThread.Start(); // start the response thread
                void ResponseThread()
                {
                    bool booleen = true;
                    while (booleen)
                    {
                        try // this is to reslove the stop command and keep it working
                        {
                            HttpListenerContext context = _httpListener.GetContext(); // get a context
                                                                                      // Now, you'll find the request URL in context.Request.Url

                            
                            
                            //byte[] _responseArray = File.ReadAllBytes(path); // get the bytes to response
                            context.Response.OutputStream.Write(File.ReadAllBytes(path), 0, File.ReadAllBytes(path).Length); // write bytes to the output stream
                            context.Response.KeepAlive = false; // set the KeepAlive bool to false
                            context.Response.Close(); // close the connection
                            calls++;
                            EXECUTION.execute();


                            
                            // logging section
                            if (Directory.Exists("Logs"))
                            {
                                //return;
                            }
                            else
                            {
                                Directory.CreateDirectory("Logs");
                            }
                           if (File.Exists("Logs\\" + LogFile))
                            {
                                //continue;
                            }
                            else
                            {
                                File.Create("Logs\\" +LogFile);
                            }
                            File.AppendAllText("Logs\\"+LogFile,"Execution Comeplete and user had called remotely ("+ calls + ") Time(s)!    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
                        







                            //Console.WriteLine("Respone given to a request.");
                        }
                        catch
                        {

                            MessageBox.Show("Oops, Something went wrong?, Ther server has been shut down...!", "LessConnect Error");
                            booleen = false;
                            File.AppendAllText("Logs\\" + LogFile, "Server Had a crash something went wrong...    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);

                        }
                    }
                    
                }
            }
            catch
            {
               // Console.WriteLine("Server Startup Failed");
                MessageBox.Show("Error Could not start server, maybe you are not admin or you have a few settings wrong", "BOS Software");
                File.AppendAllText("Logs\\" + LogFile, "Server Had a Problem Starting...    -    " + DateTime.Now  + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
            }

        }
        public static void StopServer()
        {
            try
            {
                _httpListener.Stop();
                File.AppendAllText("Logs\\" + LogFile, "Server Has been stoped...    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Error in stoping the server, Force shutdown is being initiated...", "LessConnect Error");
                File.AppendAllText("Logs\\" + LogFile, "There was an error in stopping ther server abort Connection and closing Application now...    -    " + DateTime.Now + "   " + Environment.MachineName + "   " + Environment.OSVersion + Environment.NewLine);

                 _httpListener.Abort();
                Application.Exit();
                // MessageBox.Show("Server Aborted.", "LessConnect Error");
            }

        }
    }

}
