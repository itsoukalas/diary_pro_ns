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
    public partial class search_memo : Form
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void search_memo_Load(object sender, EventArgs e)
        {
            Int32 ic;
            ic = diary_pro.Properties.Settings.Default.last_memo_id;

            for (int i = 1; i <= ic; i++)
            {
                this.listBox1.Items.Add(i.ToString());
            }
          
        }

 
        private void button2_Click_1(object sender, EventArgs e)
        {
            My_Forms.memo_from memo = new My_Forms.memo_from();

            memo.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fn;
            string fn_title;
            string fn_date;
            Int32 last_id;
            last_id = Convert.ToInt32(listBox1.Text);

            fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
            fn_title = Application.StartupPath + "\\data\\docs\\title" + last_id.ToString() + ".txt";
            fn_date = Application.StartupPath + "\\data\\docs\\date" + last_id.ToString() + ".txt";

            id_textBox3.Text = last_id.ToString() ;

            this.progress_panel1.Visible = true;
            this.progress_panel1.Refresh();
            this.richTextBox1.LoadFile(fn);
            this.progress_panel1.Visible = false;

            this.title_textBox1.Text = System.IO.File.ReadAllText(fn_title,Encoding.UTF8);
            this.date_textBox2.Text = System.IO.File.ReadAllText(fn_date,Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Int32 i = 0;
            i = this.listBox1.FindStringExact(this.search_textBox1.Text);
            if (i<0)
            {
                MessageBox.Show("Not match found,try again!!");
                search_textBox1.Clear();
                return;
            }

            try
            {
                this.listBox1.Text = search_textBox1.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Not match found,try again!!");
                search_textBox1.Clear();
                return;
            }
            
        }

      
    
    }
}
