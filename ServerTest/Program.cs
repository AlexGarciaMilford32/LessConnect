using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;


public class SynchronousSocketListener
{

    public static void Main()
    {
       
        Console.WriteLine("Trying to receive...");
        UdpClient client = null;
        try
        {
            client = new UdpClient(4525);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        while (true)
        {
            IPEndPoint server = new IPEndPoint(IPAddress.Broadcast, 4525);

            byte[] packet = client.Receive(ref server);
            Console.WriteLine(Encoding.ASCII.GetString(packet));


            if (Encoding.ASCII.GetString(packet) == "hi")
            {
                Console.WriteLine("HahhaiHSDvi osefe");

            }
        }


     



   
    }



}