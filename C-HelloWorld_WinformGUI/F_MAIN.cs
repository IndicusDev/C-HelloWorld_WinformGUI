using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_HelloWorld_WinformGUI
{
    public partial class F_MAIN : Form
    {
        public F_MAIN()
        {
            InitializeComponent();
        }

        private void BTN_HELLO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
