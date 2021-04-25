using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ung_Dung_moi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormThongTin frm = new FormThongTin();
            frm.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonQLNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonQLSach_Click(object sender, EventArgs e)
        {
            quanLySach1.BringToFront();
        }

        private void editBook1_Load(object sender, EventArgs e)
        {

        }
    }
}
