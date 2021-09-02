using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            user_info_loader();
           
            if (diary_pro.Properties.Settings.Default.flag)
            {
                password_textBox1.Text = diary_pro.Properties.Settings.Default.password;
                diary_pro.Properties.Settings.Default.flag = false;
                diary_pro.Properties.Settings.Default.Save() ;
            }
            
        }

        public void user_info_loader()
        {
            this.user_name_textBox1.Text = diary_pro.Properties.Settings.Default.user_name;
            string df;
            df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
            this.user_pictureBox1.Load(df);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.password_textBox1.Text=="")
            {
                MessageBox.Show("Password Is Empty");
                return;
            }
            
            if (this.password_textBox1.Text == diary_pro.Properties.Settings.Default.password)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Your password is not correct. Please try again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a Nice Day Dude!!");
            Application.Exit();
            //Close();
        }

        private void password_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
