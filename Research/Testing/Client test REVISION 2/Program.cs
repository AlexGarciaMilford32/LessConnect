/*
 * Created by SharpDevelop.
 * User: 19.alexander.garcia
 * Date: 11/13/2017
 * Time: 7:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_test_REVISION_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			 string IP4Address = String.Empty;

    foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
    {
        if (IPA.AddressFamily == AddressFamily.InterNetwork)
        {
            IP4Address = IPA.ToString();
            break;
        }
    }

    Console.WriteLine(IP4Address);
    Console.ReadLine();
		}
		
		
		
		
	}
}