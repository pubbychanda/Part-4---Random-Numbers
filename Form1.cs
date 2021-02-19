using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        public void int_check()
        {
            if (rdoIntegers.Checked == true)
            {
                numMinimum.Increment = 1;
            }
            else
            {
                numMinimum.Increment = 0.1;
            }
        }
        private void numMinimum_MouseUp(object sender, MouseEventArgs e)
        {
            int_check();
        }

        private void numMinimum_MouseDown(object sender, MouseEventArgs e)
        {
            int_check();
        }
    }
}
