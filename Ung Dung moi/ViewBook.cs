using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ung_Dung_moi
{
    public partial class ViewBook : UserControl
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void ViewBook_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowBook";
            guna2DataGridView1.DataSource = book.getBook(sql);
            //this.guna2DataGridView1.Fill(this.myDBDataSet2.DB_studentguna2DataGridView1);
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "select *select * from ShowRecipient("+ id +")";
            guna2DataGridView2.DataSource = book.getBook(sql);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
