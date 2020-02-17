using System;
using System.Windows.Forms;

namespace CommandInGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int val1))
            {
                MessageBox.Show("Введите целое число 1");
                return;
            }
            if (!int.TryParse(textBox2.Text, out int val2))
            {
                MessageBox.Show("Введите целое число 2");
                return;
            }

            textBoxResult.Text = (val1 + val2).ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {

        }
    }
}
