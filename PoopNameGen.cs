using System;
using System.Windows.Forms;

namespace RYTPNameGenWf
{
    public partial class PoopNameGen : Form
    {
        public PoopNameGen()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " RYTP";
        }
    }
}
