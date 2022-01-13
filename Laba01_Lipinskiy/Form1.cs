using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba01_Lipinskiy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text != "Darii")
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Error login");
                return;
            }

            if (textBox_password.Text != "123")
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Error password ");
                return;
            }

            if (textBox_login.Text == "Darii" && textBox_password.Text == "123")
            {
                label_ok.BackColor = Color.Green;
                MessageBox.Show("Hello, Darii");
            }else
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Error login and password");
                return;
            }
        }
    }
}
