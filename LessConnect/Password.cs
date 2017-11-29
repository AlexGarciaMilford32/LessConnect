using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessConnect
{
    public partial class Password : Form
    {
        //strings for other classes or forms
        public static string Key = null;



        public Password()
        {
            InitializeComponent();
        }

        private void canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okaybutton_Click(object sender, EventArgs e)
        {
            Key = passwordbox.Text;
            this.Close();
        }
    }
}
