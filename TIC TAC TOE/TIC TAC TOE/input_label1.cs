﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class input_labels : Form
    {
        public input_labels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            Form1.Form1Instance.label1_input(textBox1.Text);

            Hide();
            Close();
        }

        private void input_labels_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
