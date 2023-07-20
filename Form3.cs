using System;
using System.Windows.Forms;

namespace FirstWindowForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime dt;
            dt = dtp1.Value;
            MessageBox.Show("Selected data is " + dt.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("My fac city is " + cboCity.SelectedItem);
        }
    }
}
