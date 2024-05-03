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
    public partial class MainFormNhanVien : Form
    {
        private Form currentFormChild;
        public MainFormNhanVien()
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
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildForm1(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.BringToFront();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new ThongTinCaNhan());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (panel4.Visible == false)
            {
                panel4.Visible = true;
                panel4.BringToFront();
            }
            else panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hoadon_nhanvien());
            button2.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khachhang_Nhanvien());
            button3.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySanPham());
            button1.BackColor = panel3.BackColor;
            button3.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {

        }
    }
}
