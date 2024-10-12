using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBaru9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Username = "thaskia";
            string Password = "12345";

            string inputUser = txtuser.Text;
            string inputPassword = txtpass.Text;

            if (Username == inputUser && Password == inputPassword)
            {
                MessageBox.Show("Login Succes!!");
                Form2 form = new Form2(); 
                form.Show();
                this.Hide(); 

            }
            else
            {
                MessageBox.Show("Login Gagal Mohon Diulang kembali!");
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}

