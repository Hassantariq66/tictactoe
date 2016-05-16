using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class input_label2 : Form
    {
        public input_label2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            Form1.Form1Instance.label2_input(textBox1.Text);
            Hide();
            Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_label2_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
