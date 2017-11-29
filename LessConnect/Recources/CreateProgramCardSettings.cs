using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LessConnect.Recources;

namespace LessConnect.Recources
{
    public partial class CreateProgramCardSettings : Form
    {
        public static string Directory;
        public static string Func;


        public CreateProgramCardSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                Directory = result.ToString();
            }
        }

        private void selectaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func = selectaction.SelectedValue.ToString();
        }

        private void okaybutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
