using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessConnect.Recources;


namespace LessAPI
{
    class Less
    {
        public static void SysCheck(int cpumin)
        {
            CHECK_SYS.CHECK(cpumin);
        }
        public static void StartServer(int port, string path)
        {
            //SERVER_START.SeverStar(port, path);

        }
        public static void StopServer()
        {
            //SERVER_START.StopServer();

        }
    }
}
