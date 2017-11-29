using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LessConnect.Recources
{
    /*
     
         Program Cards : By alex garica
         
         This will enable the user to input a device with a "ProgramCard" installed on it
         this will include a USB device or any Hotswapable like device such as a dvd as well!

        This is protected Software and this specific Function is Propriatary Software and must not
        be modified or re-distributed in any way withought prior consent by the creator (Alex Garcia)


         
         
         */
    class PROGRAM_CARD
    {
        //this will create a Valid FuncCard
        public static void CreatFuncCard(string drive, string Function)
        {
            string Valid_ID = "LessConnectFuncID45252017";

            string Software = "LessConnect";
            string combinedpath = drive + "Function Card";
            string ValidFuncFile = combinedpath + "FunctionKey.LessFunction";
            string RegComputer = Environment.MachineName;


            Directory.CreateDirectory(drive + "Function Card");
            File.Create(combinedpath + "FunctionKey.LessFunction");

            StreamWriter w = new StreamWriter(ValidFuncFile);
            w.WriteLine(Valid_ID);
            w.WriteLine(Software);
            w.WriteLine(RegComputer);




            w.Close();




        }



        public static void ProgramCardFunction()
        {


        }









        public static void SEARCH_FOR_DRIVE()
        {





            ReCopy:
            while (true)
            {
                if (Directory.Exists("A:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "A:\\" + Environment.MachineName + ".txt");

                        goto ReCopy;

                    }
                    catch { }
                }
                if (Directory.Exists("B:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "B:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("D:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "D:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("E:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "E:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("F:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "F:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("G:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "G:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("H:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "H:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("I:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "I:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("J:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "J:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("K:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "K:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("L:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "L:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("M:\\"))
                {
                    try
                    {

                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "M:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("N:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "N:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("O:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "O:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("P:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "P:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("Q:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "Q:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("R:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "R:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("S:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "S:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("T:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "T:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("U:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "U:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("V:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "V:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("W:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "W:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("X:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "X:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("Y:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "Y:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }
                if (Directory.Exists("Z:\\"))
                {
                    try
                    {
                        File.Copy("ServerLog" + Environment.MachineName + ".txt", "Z:\\" + Environment.MachineName + ".txt");
                        goto ReCopy;
                        return;
                    }
                    catch { }
                }











            }
        }
    }
}
