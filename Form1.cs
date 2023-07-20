using System;
using System.Windows.Forms;

namespace FirstWindowForm
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome Audience");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt1.Text);
            float num2 = float.Parse(txt2.Text);
            float result = num1 + num2;
            txt3.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt1.Text);
            float num2 = float.Parse(txt2.Text);
            float result = num1 - num2;
            txt3.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt1.Text);
            float num2 = float.Parse(txt2.Text);
            float result = num1 * num2;
            txt3.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt1.Text);
            float num2 = float.Parse(txt2.Text);
            float result = num1 / num2;
            txt3.Text = result.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var F2 = new frmNext();
            F2.Show();
            this.Hide();
        }
    }
}
