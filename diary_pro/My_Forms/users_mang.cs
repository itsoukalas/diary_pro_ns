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
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }

     

    

       
        /// <summary>
        /// Save Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            pass_confirm_textBox2.PasswordChar = '@';
            ///-------------------------------------------------------------------------
            if (username_textBox1.Text.Length==0)
            {
                MessageBox.Show("User Name is empty");
                return;
            }
            ///-------------------------------------------------------------------------
            if (!password_textBox1.Text.Equals(pass_confirm_textBox2.Text))
            {
                MessageBox.Show("You must enter same password in both textboxes");
                return;
            }
            ///-------------------------------------------------------------------------
            diary_pro.Properties.Settings.Default.user_name = username_textBox1.Text;
            diary_pro.Properties.Settings.Default.password = password_textBox1.Text;
            diary_pro.Properties.Settings.Default.Save();

            //....save user pic.....
           
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                
                try
                {
                    string fn;
                    fn = openFileDialog1.FileName;
                    string df = (Application.StartupPath + @"\data\user_pic\1.jpg");
                    System.IO.File.Copy(fn, df, true);
                }
                catch (Exception)
                {

                   
                }
            }

            MessageBox.Show("Done!");
            
        }

        private void users_mang_Load(object sender, EventArgs e)
        {
            username_textBox1.Text = diary_pro.Properties.Settings.Default.user_name;
            password_textBox1.Text = diary_pro.Properties.Settings.Default.password;
            pass_confirm_textBox2.PasswordChar = '@';
            //........load user pic...........
            string df = (Application.StartupPath + @"\data\user_pic\1.jpg");
            pictureBox1.Load(df);
        }

        /// <summary>
        /// Select Image buttom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn = this.openFileDialog1.FileName;
            pictureBox1.Load(fn);
        }

    
    }
}
