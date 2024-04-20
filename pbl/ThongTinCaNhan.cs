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
    public partial class ThongTinCaNhan : Form
    {
        private Form currentFormChild;
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuaThongTinCaNhan());
            button1.BackColor = this.BackColor;
            button2.BackColor = panel1.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MatKhau());
            button2.BackColor = this.BackColor;
            button1.BackColor = panel1.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
