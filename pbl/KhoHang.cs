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
    public partial class KhoHang : Form
    {
        private Form currentFormChild;
        public KhoHang()
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhaPhanPhoi());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhoHang1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapKho());
        }
    }
}
