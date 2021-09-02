
namespace diary_pro.My_Forms
{
    partial class about_us
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us));
            this.site_label2 = new System.Windows.Forms.Label();
            this.product_name_label4 = new System.Windows.Forms.Label();
            this.version_label3 = new System.Windows.Forms.Label();
            this.co_name_label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // site_label2
            // 
            this.site_label2.AutoSize = true;
            this.site_label2.Location = new System.Drawing.Point(74, 201);
            this.site_label2.Name = "site_label2";
            this.site_label2.Size = new System.Drawing.Size(92, 13);
            this.site_label2.TabIndex = 11;
            this.site_label2.Text = "https://www/in.gr";
            // 
            // product_name_label4
            // 
            this.product_name_label4.AutoSize = true;
            this.product_name_label4.Location = new System.Drawing.Point(74, 131);
            this.product_name_label4.Name = "product_name_label4";
            this.product_name_label4.Size = new System.Drawing.Size(72, 13);
            this.product_name_label4.TabIndex = 10;
            this.product_name_label4.Text = "product name";
            // 
            // version_label3
            // 
            this.version_label3.AutoSize = true;
            this.version_label3.Location = new System.Drawing.Point(74, 166);
            this.version_label3.Name = "version_label3";
            this.version_label3.Size = new System.Drawing.Size(99, 13);
            this.version_label3.TabIndex = 9;
            this.version_label3.Text = "Version 2021 07 29";
            // 
            // co_name_label1
            // 
            this.co_name_label1.AutoSize = true;
            this.co_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.co_name_label1.Location = new System.Drawing.Point(110, 53);
            this.co_name_label1.Name = "co_name_label1";
            this.co_name_label1.Size = new System.Drawing.Size(122, 18);
            this.co_name_label1.TabIndex = 8;
            this.co_name_label1.Text = "company name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 3);
            this.panel1.TabIndex = 12;
            // 
            // about_us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.site_label2);
            this.Controls.Add(this.product_name_label4);
            this.Controls.Add(this.version_label3);
            this.Controls.Add(this.co_name_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about_us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About_us";
            this.Load += new System.EventHandler(this.about_us_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label site_label2;
        private System.Windows.Forms.Label product_name_label4;
        private System.Windows.Forms.Label version_label3;
        private System.Windows.Forms.Label co_name_label1;
        private System.Windows.Forms.Panel panel1;
    }
}