using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ContactsBook
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void ShowAll_btn_Click(object sender, EventArgs e)
        {
            Contacts sag = new Contacts();
            sag.ShowDialog();
        }

        private void AddContact_btn_Click(object sender, EventArgs e)
        {
            AddContact ac = new AddContact();
            ac.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchContact sc = new SearchContact();
            sc.Show();
        }
    }
}
