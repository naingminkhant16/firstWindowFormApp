using System;
using System.Windows.Forms;

namespace FirstWindowForm
{
    public partial class frmNext : Form
    {
        public frmNext()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbGreen.Checked)
            {
                MessageBox.Show("You are selected green");
            }
            else if (rdbRed.Checked)
            {
                MessageBox.Show("You are selected red");
            }
            else if (rdbYellow.Checked)
            {
                MessageBox.Show("You are selected yellow");
            }
            else MessageBox.Show("Please select one.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string st = "";
            if (chkCpp.Checked) st += " C++ \n";
            if (chkCs.Checked) st += " C# \n";
            if (chkIsad.Checked) st += " Information System analysis and design \n";
            if (chkJv.Checked) st += " Java \n";
            if (chkAnd.Checked) st += " Android \n";

            MessageBox.Show("You have already finished : \n" + st);
        }
    }
}
