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
        Random generator = new Random();
        double doublenumber;
        int integernumber;
        int decimalplaceround;
        int intMax;
        double doubleMax;

 
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
                numMinimum.DecimalPlaces = 2;
                numMinimum.Increment = 0.01M;
            }
        }
        public void generate_number()
        {
            decimalplaceround = Convert.ToInt32(numDecimalInterval.Value);

            if (Int32.TryParse(txtMaximum.Text, out intMax) || Double.TryParse(txtMaximum.Text, out doubleMax))
            {
                if (rdoIntegers.Checked == true)
                {
                    integernumber = generator.Next(Convert.ToInt32(numMinimum.Value), Convert.ToInt32(txtMaximum.Text));
                    lblAnswer.Text = Convert.ToString(integernumber);
                }
                else
                {
                    doublenumber = generator.NextDouble() * (Convert.ToDouble(txtMaximum.Text) - Convert.ToDouble(numMinimum.Value)) + Convert.ToDouble(numMinimum.Value);
                    doublenumber = Math.Round(doublenumber, decimalplaceround);
                    lblAnswer.Text = Convert.ToString(doublenumber);
                }
            }
            else
            {
                lblAnswer.Text = "Enter a valid number.";
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

        private void lblGetResult_Click(object sender, EventArgs e)
        {
            generate_number();
        
        }
    }
}
