﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class NhapKho : Form
    {
        public NhapKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning f = new Warning();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
