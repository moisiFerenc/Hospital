using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            if (1 == 1){//username == "1" && password == "1") {
                this.Hide();
                dashboard ds = new dashboard();
                ds.Show();
            }
            else {
                MessageBox.Show("invalid username or password");
            }

        }
    }
}
