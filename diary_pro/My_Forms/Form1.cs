using diary_pro.My_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        public void getTime() => timer_label1.Text = DateTime.Now.ToString("HH:mm:ss");


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                diary_pro.My_Forms.login_form lg_from = new My_Forms.login_form();
                lg_from.ShowDialog();
                getTime();
                
                System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();
                this.year_label2.Text = g.GetYear(DateTime.Now).ToString();
                this.day_label4.Text = g.GetDayOfMonth(DateTime.Now).ToString();
                this.dayOfWeek_bel2.Text = g.GetDayOfWeek(DateTime.Now).ToString();

                int fooint = g.GetMonth(DateTime.Now);
                var foo = (Month)fooint;
                month_label3.Text = foo.ToString();

                //Load Resource
                version_label2.Text = Application.ProductVersion;
                back_image_loader(diary_pro.Properties.Settings.Default.selected_bg_image_index);

                string i = (diary_pro.Properties.Settings.Default.selected_music_index).ToString();

                this.axWindowsMediaPlayer2.URL = Application.StartupPath + $"\\data\\music\\{i}.mp3";
          
                ////Loaders combo box
                background_combo_loader();
                music_combo_loader();
                //.................................Load User Info................................
                user_pictureBox1.Load((Application.StartupPath + @"\data\user_pic\1.jpg"));
                username_label5.Text = diary_pro.Properties.Settings.Default.user_name;
            }
            catch (Exception ex)
            {
                comm_class.my_error_msg(ex.Message);
            }
        }



        public void back_image_loader(short name)
        {
            string fn;
            fn = Application.StartupPath + $"\\data\\pics\\{name+1}.jpg";
            
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
           
        }



        public void background_combo_loader()
        {
            for (int i = 1; i < 9; i++)
            {
                this.bg_comboBox.Items.Add("Image "+i);
                
            }
            
        }

        public void music_combo_loader()
        {

            for (int i = 1; i <= 2; i++)
            {
                this.music_comboBox.Items.Add("music " + i);
            }
        }

  


        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        };

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bg_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            short i = 1;
            i = (short)bg_comboBox.SelectedIndex;
            back_image_loader(i);
            //save selected image index
            diary_pro.Properties.Settings.Default.selected_bg_image_index = i;
            diary_pro.Properties.Settings.Default.Save();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            short i=(short)ra.Next(0, 8);
            back_image_loader(i);
            
        }

        private void music_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = diary_pro.Properties.Settings.Default.selected_music_index= music_comboBox.SelectedIndex+1 ;
            diary_pro.Properties.Settings.Default.Save();
            string fn;
            fn = Application.StartupPath+ $"\\data\\music\\{(i).ToString()}.mp3";
            //this.axWindowsMediaPlayer2.URL = fn;
            loader = fn;
        }

        

        public string loader { get; set; }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.URL = loader;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Forms.about_us ab = new My_Forms.about_us();
            ab.MdiParent = this;
            ab.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Forms.help help = new My_Forms.help();
           
            help.ShowDialog();
        }

        public My_Forms.users_mang users = new My_Forms.users_mang();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            users.MdiParent = this;
            users.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void username_label5_Click(object sender, EventArgs e)
        {

        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.login_form lg_from = new My_Forms.login_form();
            lg_from.ShowDialog();
        }

        private void refleshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            My_Forms.memo_from memo = new My_Forms.memo_from();
            memo.MdiParent = this;
            memo.Show();
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search_memo search = new search_memo();
            search.MdiParent = this;
            search.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         
            switch (e.KeyCode)
            {
                case Keys.F2:
                    toolStripButton2_Click(sender, e);
                    break;
                case Keys.F3:
                    toolStripButton1_Click(sender, e);
                    break;
                case Keys.F4:
                    setting_toolStripButton6.ShowDropDown();
                    break;
                case Keys.F5:
                    tools_toolStripDropDownButton1.ShowDropDown();
                    break;
                case Keys.F6:
                    about_toolStripButton5.ShowDropDown();
                    break;
                case Keys.Escape:
                    button3_Click(sender, e);
                    break;
               
                default:
                    break;
            }
        }

   

    }
}
