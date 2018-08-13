using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readDBWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLHelper sql = new SQLHelper();
        private void query_Click(object sender, EventArgs e)
        {
           

           dataGridView1.DataSource = sql.Query();
        }

        private void outport_Click(object sender, EventArgs e)
        {
            string a = "D:" + "\\DB.xls";
            sql.excelport(a, dataGridView1);
        }
    }
}
