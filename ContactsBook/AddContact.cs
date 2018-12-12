using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ContactsBook
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }
        
        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {
            string FirstName = txtfirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone  = txtPhone.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool check = ValidateInput();
            if (!check)
            {
                MessageBox.Show("Error - Must fill at Least 1 Field");
            }
            else
            {
                int res = 0;
                res = AppData.AddContact(txtfirstName.Text, txtLastName.Text, txtPhone.Text);
                if (res > 0 )
                {
                    MessageBox.Show("Saved");
                    this.Close();
                }
                else if (res == -1)
                {
                    MessageBox.Show("Error -Phone Number Already Exists!");
                    this.Close();
                }
            }
        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            txtfirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
        }
        private bool ValidateInput()
        {
            var fn = txtfirstName.Text;
            var ln = txtLastName.Text;
            var ph = txtPhone.Text;
            if ((string.IsNullOrEmpty(fn)) && (string.IsNullOrEmpty(ln)) && (string.IsNullOrEmpty(ph)))
            {
                return false;
            }
            return true;
        }

        //private void AddPic_btn_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        AddPic_btn.Text = open.FileName;
        //    }
        //    string image = AddPic_btn.Text;
        //    Bitmap bmp = new Bitmap(image);
        //    FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
        //    byte[] bimage = new byte[fs.Length];
        //    fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
        //    fs.Close();

            
        //}
    }
}
