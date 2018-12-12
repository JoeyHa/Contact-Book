using System;
using System.Data;
using System.Windows.Forms;


namespace ContactsBook
{
    
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
            ShowAllData();
        }

        void ShowAllData()       
        {
            DataTable dt = AppData.ShowAllContacts();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }
    }
}
