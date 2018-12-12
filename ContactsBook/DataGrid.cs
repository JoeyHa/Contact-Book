using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsBook
{
    public partial class DataGrid : Form
    {
        
        public DataGrid()
        {
            InitializeComponent();
        }
        public void ShowSearchRes(DataTable dt)
        {
            int rows = dt.Rows.Count;
            if (rows == 0)
            {
                MessageBox.Show("No Contacts Found");
            }
            else
            {
                dataGridView1.DataSource = dt.DefaultView;
                showSearchGrid();
            }
                    
        }
        private void showSearchGrid()
        {
            ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = null;
            //EditContact ec = new EditContact();
            string val = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            dt = AppData.GetDataFromGrid(val);

        }
    }
}
