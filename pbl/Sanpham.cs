using System;
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
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themsanpham f = new Themsanpham();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning f = new Warning();
            f.Show();
        }

    }
}
