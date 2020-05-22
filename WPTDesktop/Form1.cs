using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WPTDesktop
{
    public partial class Form1 : Form
    {
        WPTService.WebService proxy = new WPTService.WebService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int result = int.Parse(proxy.Login(username, password));
            if (result == 1)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
                lblInfo.Text = "Niste ispravno unjeli podatke!";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
