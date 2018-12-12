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
    public partial class SearchContact : Form
    {
        DataGrid grid = new DataGrid();
        public SearchContact()
        {
            InitializeComponent();
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool check = ValidateInput();
            if (!check)
            {
                MessageBox.Show("Must Fill at least 1 field for search");
            }
            else
            {
                DataTable dt = null;
                dt = AppData.SearchContact(FirstNameSearch.Text, LastNameSearch.Text, PhoneSearch.Text);
                grid.ShowSearchRes(dt);
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            FirstNameSearch.Text = "";
            LastNameSearch.Text = "";
            PhoneSearch.Text = "";
        }
        private bool ValidateInput()
        {
            var fn = FirstNameSearch.Text;
            var ln = LastNameSearch.Text;
            var ph = PhoneSearch.Text;
            if ((string.IsNullOrEmpty(fn)) && (string.IsNullOrEmpty(ln)) &&  (string.IsNullOrEmpty(ph)))
            {
                return false;
            }
            return true;
        }
    }
}
