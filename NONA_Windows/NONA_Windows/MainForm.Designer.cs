namespace NONA_Windows
{
    partial class NONAMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NONAMain));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.portraitLogo = new System.Windows.Forms.Label();
            this.accountButton = new System.Windows.Forms.PictureBox();
            this.recentButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.Panel();
            this.pImg9 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.p8 = new System.Windows.Forms.Panel();
            this.pImg8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.Panel();
            this.pImg7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Panel();
            this.pImg6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Panel();
            this.pImg5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Panel();
            this.pImg4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.pImg3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.pImg2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.pImg1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tileRefreshWorker = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notificationService = new System.ComponentModel.BackgroundWorker();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.p9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg9)).BeginInit();
            this.p8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg8)).BeginInit();
            this.p7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg7)).BeginInit();
            this.p6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg6)).BeginInit();
            this.p5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg5)).BeginInit();
            this.p4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg4)).BeginInit();
            this.p3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg3)).BeginInit();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg2)).BeginInit();
            this.p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuPanel.Controls.Add(this.portraitLogo);
            this.menuPanel.Controls.Add(this.accountButton);
            this.menuPanel.Controls.Add(this.recentButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(64, 561);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            // 
            // portraitLogo
            // 
            this.portraitLogo.AutoSize = true;
            this.portraitLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.portraitLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.portraitLogo.Location = new System.Drawing.Point(7, 185);
            this.portraitLogo.Name = "portraitLogo";
            this.portraitLogo.Size = new System.Drawing.Size(55, 204);
            this.portraitLogo.TabIndex = 8;
            this.portraitLogo.Text = "N\r\nO\r\nN\r\nA";
            this.portraitLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.portraitLogo_MouseDown);
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.Transparent;
            this.accountButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accountButton.Image = ((System.Drawing.Image)(resources.GetObject("accountButton.Image")));
            this.accountButton.Location = new System.Drawing.Point(0, 497);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(64, 64);
            this.accountButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accountButton.TabIndex = 7;
            this.accountButton.TabStop = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            this.accountButton.MouseEnter += new System.EventHandler(this.accountButton_MouseEnter);
            this.accountButton.MouseLeave += new System.EventHandler(this.accountButton_MouseLeave);
            // 
            // recentButton
            // 
            this.recentButton.BackColor = System.Drawing.Color.Transparent;
            this.recentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentButton.Image = ((System.Drawing.Image)(resources.GetObject("recentButton.Image")));
            this.recentButton.Location = new System.Drawing.Point(0, 64);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(64, 64);
            this.recentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recentButton.TabIndex = 5;
            this.recentButton.TabStop = false;
            this.recentButton.Click += new System.EventHandler(this.recentButton_Click);
            this.recentButton.MouseEnter += new System.EventHandler(this.recentButton_MouseEnter);
            this.recentButton.MouseLeave += new System.EventHandler(this.recentButton_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(64, 64);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 4;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            // 
            // p9
            // 
            this.p9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p9.Controls.Add(this.pImg9);
            this.p9.Controls.Add(this.label9);
            this.p9.Location = new System.Drawing.Point(700, 390);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(250, 125);
            this.p9.TabIndex = 17;
            // 
            // pImg9
            // 
            this.pImg9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg9.ErrorImage = null;
            this.pImg9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg9.InitialImage")));
            this.pImg9.Location = new System.Drawing.Point(46, 0);
            this.pImg9.Name = "pImg9";
            this.pImg9.Size = new System.Drawing.Size(204, 125);
            this.pImg9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg9.TabIndex = 3;
            this.pImg9.TabStop = false;
            this.pImg9.Click += new System.EventHandler(this.pImg9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 51);
            this.label9.TabIndex = 2;
            this.label9.Text = "9";
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p8.Controls.Add(this.pImg8);
            this.p8.Controls.Add(this.label8);
            this.p8.Location = new System.Drawing.Point(400, 390);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(250, 125);
            this.p8.TabIndex = 16;
            // 
            // pImg8
            // 
            this.pImg8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg8.ErrorImage = null;
            this.pImg8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg8.InitialImage")));
            this.pImg8.Location = new System.Drawing.Point(46, 0);
            this.pImg8.Name = "pImg8";
            this.pImg8.Size = new System.Drawing.Size(204, 125);
            this.pImg8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg8.TabIndex = 3;
            this.pImg8.TabStop = false;
            this.pImg8.Click += new System.EventHandler(this.pImg8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 51);
            this.label8.TabIndex = 2;
            this.label8.Text = "8";
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p7.Controls.Add(this.pImg7);
            this.p7.Controls.Add(this.label7);
            this.p7.Location = new System.Drawing.Point(100, 390);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(250, 125);
            this.p7.TabIndex = 15;
            // 
            // pImg7
            // 
            this.pImg7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg7.ErrorImage = null;
            this.pImg7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg7.InitialImage")));
            this.pImg7.Location = new System.Drawing.Point(46, 0);
            this.pImg7.Name = "pImg7";
            this.pImg7.Size = new System.Drawing.Size(204, 125);
            this.pImg7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg7.TabIndex = 3;
            this.pImg7.TabStop = false;
            this.pImg7.Click += new System.EventHandler(this.pImg7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 51);
            this.label7.TabIndex = 2;
            this.label7.Text = "7";
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p6.Controls.Add(this.pImg6);
            this.p6.Controls.Add(this.label6);
            this.p6.Location = new System.Drawing.Point(700, 215);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(250, 125);
            this.p6.TabIndex = 14;
            // 
            // pImg6
            // 
            this.pImg6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg6.ErrorImage = null;
            this.pImg6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg6.InitialImage")));
            this.pImg6.Location = new System.Drawing.Point(46, 0);
            this.pImg6.Name = "pImg6";
            this.pImg6.Size = new System.Drawing.Size(204, 125);
            this.pImg6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg6.TabIndex = 3;
            this.pImg6.TabStop = false;
            this.pImg6.Click += new System.EventHandler(this.pImg6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 51);
            this.label6.TabIndex = 2;
            this.label6.Text = "6";
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p5.Controls.Add(this.pImg5);
            this.p5.Controls.Add(this.label5);
            this.p5.Location = new System.Drawing.Point(400, 215);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(250, 125);
            this.p5.TabIndex = 13;
            // 
            // pImg5
            // 
            this.pImg5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg5.ErrorImage = null;
            this.pImg5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg5.InitialImage")));
            this.pImg5.Location = new System.Drawing.Point(46, 0);
            this.pImg5.Name = "pImg5";
            this.pImg5.Size = new System.Drawing.Size(204, 125);
            this.pImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg5.TabIndex = 3;
            this.pImg5.TabStop = false;
            this.pImg5.Click += new System.EventHandler(this.pImg5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 51);
            this.label5.TabIndex = 2;
            this.label5.Text = "5";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p4.Controls.Add(this.pImg4);
            this.p4.Controls.Add(this.label4);
            this.p4.Location = new System.Drawing.Point(100, 215);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(250, 125);
            this.p4.TabIndex = 12;
            // 
            // pImg4
            // 
            this.pImg4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg4.ErrorImage = null;
            this.pImg4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg4.InitialImage")));
            this.pImg4.Location = new System.Drawing.Point(46, 0);
            this.pImg4.Name = "pImg4";
            this.pImg4.Size = new System.Drawing.Size(204, 125);
            this.pImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg4.TabIndex = 3;
            this.pImg4.TabStop = false;
            this.pImg4.Click += new System.EventHandler(this.pImg4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 51);
            this.label4.TabIndex = 2;
            this.label4.Text = "4";
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p3.Controls.Add(this.pImg3);
            this.p3.Controls.Add(this.label3);
            this.p3.Location = new System.Drawing.Point(700, 42);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(250, 125);
            this.p3.TabIndex = 10;
            // 
            // pImg3
            // 
            this.pImg3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg3.ErrorImage = null;
            this.pImg3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg3.InitialImage")));
            this.pImg3.Location = new System.Drawing.Point(46, 0);
            this.pImg3.Name = "pImg3";
            this.pImg3.Size = new System.Drawing.Size(204, 125);
            this.pImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg3.TabIndex = 3;
            this.pImg3.TabStop = false;
            this.pImg3.Click += new System.EventHandler(this.pImg3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p2.Controls.Add(this.pImg2);
            this.p2.Controls.Add(this.label2);
            this.p2.Location = new System.Drawing.Point(400, 42);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(250, 125);
            this.p2.TabIndex = 11;
            // 
            // pImg2
            // 
            this.pImg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg2.ErrorImage = null;
            this.pImg2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg2.InitialImage")));
            this.pImg2.Location = new System.Drawing.Point(46, 0);
            this.pImg2.Name = "pImg2";
            this.pImg2.Size = new System.Drawing.Size(204, 125);
            this.pImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg2.TabIndex = 3;
            this.pImg2.TabStop = false;
            this.pImg2.Click += new System.EventHandler(this.pImg2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "2";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p1.Controls.Add(this.pImg1);
            this.p1.Controls.Add(this.label1);
            this.p1.Location = new System.Drawing.Point(100, 42);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(250, 125);
            this.p1.TabIndex = 9;
            // 
            // pImg1
            // 
            this.pImg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImg1.ErrorImage = null;
            this.pImg1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImg1.InitialImage")));
            this.pImg1.Location = new System.Drawing.Point(46, 0);
            this.pImg1.Name = "pImg1";
            this.pImg1.Size = new System.Drawing.Size(204, 125);
            this.pImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImg1.TabIndex = 1;
            this.pImg1.TabStop = false;
            this.pImg1.Click += new System.EventHandler(this.pImg1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // tileRefreshWorker
            // 
            this.tileRefreshWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tileRefreshWorker_DoWork);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // notificationService
            // 
            this.notificationService.DoWork += new System.ComponentModel.DoWorkEventHandler(this.notificationService_DoWork);
            // 
            // NONAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NONAMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노나묵자";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NONAMain_MouseDown);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.p9.ResumeLayout(false);
            this.p9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg9)).EndInit();
            this.p8.ResumeLayout(false);
            this.p8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg8)).EndInit();
            this.p7.ResumeLayout(false);
            this.p7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg7)).EndInit();
            this.p6.ResumeLayout(false);
            this.p6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg6)).EndInit();
            this.p5.ResumeLayout(false);
            this.p5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg5)).EndInit();
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg4)).EndInit();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg3)).EndInit();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg2)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox recentButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox accountButton;
        private System.Windows.Forms.Label portraitLogo;
        private System.Windows.Forms.Panel p9;
        private System.Windows.Forms.Panel p8;
        private System.Windows.Forms.Panel p7;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pImg1;
        private System.Windows.Forms.PictureBox pImg9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pImg8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pImg7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pImg6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pImg5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pImg4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pImg3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pImg2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker tileRefreshWorker;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker notificationService;
    }
}

