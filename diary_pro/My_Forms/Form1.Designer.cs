
namespace diary_pro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.username_label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.music_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dayOfWeek_bel2 = new System.Windows.Forms.Label();
            this.day_label4 = new System.Windows.Forms.Label();
            this.month_label3 = new System.Windows.Forms.Label();
            this.year_label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.setting_toolStripButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about_toolStripButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bg_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.version_label2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lock_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refleshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.lock_cm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.timer_label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.username_label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.user_pictureBox1);
            this.panel6.Location = new System.Drawing.Point(0, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 163);
            this.panel6.TabIndex = 7;
            // 
            // username_label5
            // 
            this.username_label5.AutoSize = true;
            this.username_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username_label5.ForeColor = System.Drawing.Color.DarkRed;
            this.username_label5.Location = new System.Drawing.Point(69, 133);
            this.username_label5.Name = "username_label5";
            this.username_label5.Size = new System.Drawing.Size(14, 20);
            this.username_label5.TabIndex = 9;
            this.username_label5.Text = "-";
            this.username_label5.Click += new System.EventHandler(this.username_label5_Click);
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
            this.user_pictureBox1.Location = new System.Drawing.Point(44, 8);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox1.TabIndex = 7;
            this.user_pictureBox1.TabStop = false;
            this.user_pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.music_comboBox);
            this.panel5.Controls.Add(this.axWindowsMediaPlayer2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 125);
            this.panel5.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // music_comboBox
            // 
            this.music_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.music_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.music_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music_comboBox.FormattingEnabled = true;
            this.music_comboBox.Location = new System.Drawing.Point(40, 95);
            this.music_comboBox.Name = "music_comboBox";
            this.music_comboBox.Size = new System.Drawing.Size(41, 21);
            this.music_comboBox.TabIndex = 4;
            this.music_comboBox.SelectedIndexChanged += new System.EventHandler(this.music_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Music";
            // 
            // timer_label1
            // 
            this.timer_label1.BackColor = System.Drawing.Color.Black;
            this.timer_label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label1.ForeColor = System.Drawing.Color.White;
            this.timer_label1.Location = new System.Drawing.Point(0, 9);
            this.timer_label1.Name = "timer_label1";
            this.timer_label1.Size = new System.Drawing.Size(223, 41);
            this.timer_label1.TabIndex = 5;
            this.timer_label1.Text = "12:13:20";
            this.timer_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::diary_pro.Properties.Resources.desktop;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(-1, 628);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Show Desktop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::diary_pro.Properties.Resources.calander;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dayOfWeek_bel2);
            this.panel2.Controls.Add(this.day_label4);
            this.panel2.Controls.Add(this.month_label3);
            this.panel2.Controls.Add(this.year_label2);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 207);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Location = new System.Drawing.Point(0, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 53);
            this.panel4.TabIndex = 6;
            // 
            // dayOfWeek_bel2
            // 
            this.dayOfWeek_bel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayOfWeek_bel2.BackColor = System.Drawing.Color.Transparent;
            this.dayOfWeek_bel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dayOfWeek_bel2.ForeColor = System.Drawing.Color.Black;
            this.dayOfWeek_bel2.Location = new System.Drawing.Point(39, 133);
            this.dayOfWeek_bel2.Name = "dayOfWeek_bel2";
            this.dayOfWeek_bel2.Size = new System.Drawing.Size(99, 31);
            this.dayOfWeek_bel2.TabIndex = 3;
            this.dayOfWeek_bel2.Text = "Sunday";
            // 
            // day_label4
            // 
            this.day_label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day_label4.AutoSize = true;
            this.day_label4.BackColor = System.Drawing.Color.Transparent;
            this.day_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.day_label4.ForeColor = System.Drawing.Color.Black;
            this.day_label4.Location = new System.Drawing.Point(74, 90);
            this.day_label4.Name = "day_label4";
            this.day_label4.Size = new System.Drawing.Size(55, 37);
            this.day_label4.TabIndex = 2;
            this.day_label4.Text = "27";
            // 
            // month_label3
            // 
            this.month_label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.month_label3.BackColor = System.Drawing.Color.Transparent;
            this.month_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.month_label3.ForeColor = System.Drawing.Color.White;
            this.month_label3.Location = new System.Drawing.Point(141, 54);
            this.month_label3.Name = "month_label3";
            this.month_label3.Size = new System.Drawing.Size(42, 27);
            this.month_label3.TabIndex = 1;
            this.month_label3.Text = "June";
            this.month_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_label2
            // 
            this.year_label2.AutoSize = true;
            this.year_label2.BackColor = System.Drawing.Color.Transparent;
            this.year_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.year_label2.ForeColor = System.Drawing.Color.White;
            this.year_label2.Location = new System.Drawing.Point(9, 50);
            this.year_label2.Name = "year_label2";
            this.year_label2.Size = new System.Drawing.Size(54, 24);
            this.year_label2.TabIndex = 0;
            this.year_label2.Text = "2021";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.setting_toolStripButton6,
            this.tools_toolStripDropDownButton1,
            this.about_toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(227, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 59);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::diary_pro.Properties.Resources.add_memo;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 53);
            this.toolStripButton2.Text = "Add Memo F2";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::diary_pro.Properties.Resources.search_memo;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 53);
            this.toolStripButton1.Text = "Search Memo F3";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // setting_toolStripButton6
            // 
            this.setting_toolStripButton6.AutoSize = false;
            this.setting_toolStripButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.setting_toolStripButton6.Image = global::diary_pro.Properties.Resources.settings_alt_32;
            this.setting_toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setting_toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setting_toolStripButton6.Name = "setting_toolStripButton6";
            this.setting_toolStripButton6.Size = new System.Drawing.Size(110, 53);
            this.setting_toolStripButton6.Text = "Setting F4";
            this.setting_toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::diary_pro.Properties.Resources.settings_alt_32;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.usersToolStripMenuItem.Text = "Settings";
            // 
            // tools_toolStripDropDownButton1
            // 
            this.tools_toolStripDropDownButton1.AutoSize = false;
            this.tools_toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.tools_toolStripDropDownButton1.Image = global::diary_pro.Properties.Resources.tools;
            this.tools_toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tools_toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_toolStripDropDownButton1.Name = "tools_toolStripDropDownButton1";
            this.tools_toolStripDropDownButton1.Size = new System.Drawing.Size(110, 53);
            this.tools_toolStripDropDownButton1.Text = "Tools F5";
            this.tools_toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::diary_pro.Properties.Resources.tools;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 38);
            this.toolStripMenuItem1.Text = "Users";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // about_toolStripButton5
            // 
            this.about_toolStripButton5.AutoSize = false;
            this.about_toolStripButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.about_toolStripButton5.Image = global::diary_pro.Properties.Resources.about;
            this.about_toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_toolStripButton5.Name = "about_toolStripButton5";
            this.about_toolStripButton5.Size = new System.Drawing.Size(110, 53);
            this.about_toolStripButton5.Text = "About F6";
            this.about_toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::diary_pro.Properties.Resources.about;
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bg_comboBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.version_label2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 32);
            this.panel3.TabIndex = 5;
            // 
            // bg_comboBox
            // 
            this.bg_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bg_comboBox.FormattingEnabled = true;
            this.bg_comboBox.Location = new System.Drawing.Point(862, 3);
            this.bg_comboBox.Name = "bg_comboBox";
            this.bg_comboBox.Size = new System.Drawing.Size(121, 21);
            this.bg_comboBox.TabIndex = 6;
            this.bg_comboBox.SelectedIndexChanged += new System.EventHandler(this.bg_comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Background";
            // 
            // version_label2
            // 
            this.version_label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.version_label2.AutoSize = true;
            this.version_label2.Location = new System.Drawing.Point(268, 9);
            this.version_label2.Name = "version_label2";
            this.version_label2.Size = new System.Drawing.Size(10, 13);
            this.version_label2.TabIndex = 2;
            this.version_label2.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lock_cm
            // 
            this.lock_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockApplicationToolStripMenuItem,
            this.refleshToolStripMenuItem});
            this.lock_cm.Name = "lock_cm";
            this.lock_cm.Size = new System.Drawing.Size(164, 48);
            // 
            // lockApplicationToolStripMenuItem
            // 
            this.lockApplicationToolStripMenuItem.Name = "lockApplicationToolStripMenuItem";
            this.lockApplicationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lockApplicationToolStripMenuItem.Text = "Lock Application";
            this.lockApplicationToolStripMenuItem.Click += new System.EventHandler(this.lockApplicationToolStripMenuItem_Click);
            // 
            // refleshToolStripMenuItem
            // 
            this.refleshToolStripMenuItem.Name = "refleshToolStripMenuItem";
            this.refleshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.refleshToolStripMenuItem.Text = "Reflesh";
            this.refleshToolStripMenuItem.Click += new System.EventHandler(this.refleshToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::diary_pro.Properties.Resources.Close_butt;
            this.button3.Location = new System.Drawing.Point(968, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::diary_pro.Properties.Resources.Minimize_butt;
            this.button2.Location = new System.Drawing.Point(948, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(-2, 4);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(223, 88);
            this.axWindowsMediaPlayer2.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(204, 48);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 661);
            this.ContextMenuStrip = this.lock_cm;
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.lock_cm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton setting_toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tools_toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton about_toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label timer_label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dayOfWeek_bel2;
        private System.Windows.Forms.Label day_label4;
        private System.Windows.Forms.Label month_label3;
        private System.Windows.Forms.Label year_label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label version_label2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.ComboBox bg_comboBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox music_comboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Label username_label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip lock_cm;
        private System.Windows.Forms.ToolStripMenuItem lockApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refleshToolStripMenuItem;
    }
}

