
namespace diary_pro.My_Forms
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel6 = new System.Windows.Forms.Panel();
            this.user_name_textBox1 = new System.Windows.Forms.TextBox();
            this.password_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.user_name_textBox1);
            this.panel6.Controls.Add(this.password_textBox1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.user_pictureBox1);
            this.panel6.Location = new System.Drawing.Point(33, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 295);
            this.panel6.TabIndex = 8;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // user_name_textBox1
            // 
            this.user_name_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.user_name_textBox1.Location = new System.Drawing.Point(77, 141);
            this.user_name_textBox1.Name = "user_name_textBox1";
            this.user_name_textBox1.ReadOnly = true;
            this.user_name_textBox1.Size = new System.Drawing.Size(228, 22);
            this.user_name_textBox1.TabIndex = 12;
            // 
            // password_textBox1
            // 
            this.password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password_textBox1.Location = new System.Drawing.Point(77, 180);
            this.password_textBox1.Name = "password_textBox1";
            this.password_textBox1.Size = new System.Drawing.Size(228, 22);
            this.password_textBox1.TabIndex = 11;
            this.password_textBox1.Tag = "";
            this.password_textBox1.TextChanged += new System.EventHandler(this.password_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Name";
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.Location = new System.Drawing.Point(91, 3);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(118, 125);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox1.TabIndex = 7;
            this.user_pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to my diary application ";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::diary_pro.Properties.Resources.Close_butt;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(275, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "EXIT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::diary_pro.Properties.Resources.ok;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(33, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(402, 454);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Diary Pro";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox user_name_textBox1;
    }
}