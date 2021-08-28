using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterAuthCSharpForms
{
    public partial class BetterAuth : Form
    {
        public BetterAuth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(betterauth.c_login(username, password))
            {
                panelLogReg.Visible = false;
                panelsubs.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (betterauth.c_register(username, password))
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelsubs.Visible = false;
            btnDownload.Visible = false;
        }

        private void comboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool has_sub;
                string time_left = betterauth.has_sub(Convert.ToUInt32(comboproduct.SelectedIndex), out has_sub);
                if (has_sub)
                {
                    lbltimeleft.Text = time_left;
                    btnDownload.Visible = true;
                }
                else
                {
                    lbltimeleft.Text = "";
                    btnDownload.Visible = false;
                }

           
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            UInt64 data; UInt32 size;
                if(betterauth.get_file(Convert.ToUInt32(comboproduct.SelectedIndex), out data, out size))
                {
                    MessageBox.Show("Downloaded data");
                }
                else
                {
                    MessageBox.Show("Couldn't download data");
                }
        }

        private void btnactivatekey_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            betterauth.c_activatekey(key);
        }
    }
}
