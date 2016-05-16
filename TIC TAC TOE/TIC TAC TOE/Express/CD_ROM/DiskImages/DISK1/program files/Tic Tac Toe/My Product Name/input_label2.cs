using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE.bin.Debug
{
    public partial class input_label2 : Form
    {
        public input_label2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Form1Instance.label2_input(label1.Text);
        }
    }
}
