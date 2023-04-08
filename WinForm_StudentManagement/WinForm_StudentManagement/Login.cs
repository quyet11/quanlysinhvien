using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_StudentManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set username and password
            //quyet is username and 12345 is password
            if(txtUsername.Text=="quyet"&& txtpassword.Text=="12345")
            {
                //Hide form login and open form form1
                this.Hide();
                Form1 form2 = new Form1();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                //if the username and password is false
                MessageBox.Show("the username or password is incorrect, try again");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Clear fields button
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Exit button
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            //show and hide password
            if
                (checkBox_show_hide.Checked)
            {
                txtpassword.UseSystemPasswordChar= true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar= false;   
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
