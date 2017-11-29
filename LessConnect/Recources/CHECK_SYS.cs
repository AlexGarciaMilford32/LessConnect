using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessConnect;
using System.Windows.Forms;




namespace LessConnect.Recources
{
    class CHECK_SYS
    {
        public static int errors = 0;
        public static void CHECK(int cpumin)
        {

            if (Environment.ProcessorCount > cpumin)
            {
                return;
            }
            else
            {
                MessageBox.Show("Warning : Your CPU count is below the minimum requierments", "LessConnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }








        }
    }
}
