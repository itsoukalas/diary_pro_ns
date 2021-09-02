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
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            co_name_label1.Text = Application.CompanyName;
            product_name_label4.Text = Application.ProductName;
            site_label2.Text = diary_pro.Properties.Settings.Default.site;
        }
    }
}
