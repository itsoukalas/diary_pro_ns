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
    public partial class memo_from : Form
    {
        public memo_from()
        {
            InitializeComponent();
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
                
        }

        /// <summary>
        /// New Memo F2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            new_button1.Enabled = false;
            save_button2.Enabled = true;
            //--------------------------------
            Int32 i;
            i = diary_pro.Properties.Settings.Default.last_memo_id +1;
            id_textBox3.Text = i.ToString() ;
           
        }

        /// <summary>
        /// Save F5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            save_button2.Enabled = false;
            new_button1.Enabled = true;
            //--------------------------------
            int last_id;
            last_id = diary_pro.Properties.Settings.Default.last_memo_id;
            last_id += 1;
            //--------------------------------
            diary_pro.Properties.Settings.Default.last_memo_id = last_id;
            diary_pro.Properties.Settings.Default.Save();
            //--------------------------------
            string fn;
            string fn_title;
            string fn_date;
            fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf" ;
            fn_title = Application.StartupPath + "\\data\\docs\\title" + last_id.ToString() + ".txt" ;
            fn_date = Application.StartupPath + "\\data\\docs\\date" + last_id.ToString() + ".txt" ;
            //--------------------------------
  
            System.IO.File.WriteAllText(fn_title, title_textBox1.Text,Encoding.UTF8);
            System.IO.File.WriteAllText(fn_date, date_textBox2.Text, Encoding.UTF8);
            //--------------------------------
            richTextBox1.SaveFile(fn);
    
         
            MessageBox.Show("Your memo save!!");
            //--------------------------------
            title_textBox1.ResetText();
            date_textBox2.ResetText();
            richTextBox1.ResetText();
            //--------------------------------

            Close();

        }

        private void memo_from_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            save_button2.Enabled = false;
            new_button1.Enabled = true;

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
         
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            int i = richTextBox1.SelectionIndent;
            i -= 10;
            richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            int i = richTextBox1.SelectionIndent;
            i += 10;
            richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton10_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton11_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton12_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            diary_pro.Properties.Settings.Default.last_memo_id = 0;
            diary_pro.Properties.Settings.Default.Save();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }


        private void memo_from_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    

                    break;
                case Keys.F5:
                    button2_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
