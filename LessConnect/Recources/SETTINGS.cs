using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LessConnect.Recources
{
    class SETTINGS
    {
        //this call is strictly for settings

       // public static String ShowAdvancedtools = null;




        public static void ShowDevTools(string ShowAdvancedtools)
        {
            StreamReader A = new StreamReader("Settings\\showadmintools.txt");
            A.ReadLine();
            ShowAdvancedtools = A.ReadLine();
            A.Close();


        }









    }
}
