namespace NONA_Windows
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.qrGroup = new System.Windows.Forms.GroupBox();
            this.qrImage = new System.Windows.Forms.PictureBox();
            this.loginGroup = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.pwLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.pwInputBox = new System.Windows.Forms.TextBox();
            this.idInputBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.qrGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrImage)).BeginInit();
            this.loginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.titleLabel.Location = new System.Drawing.Point(90, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(107, 44);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "로그인";
            // 
            // qrGroup
            // 
            this.qrGroup.Controls.Add(this.qrImage);
            this.qrGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.qrGroup.Location = new System.Drawing.Point(21, 100);
            this.qrGroup.Name = "qrGroup";
            this.qrGroup.Size = new System.Drawing.Size(275, 275);
            this.qrGroup.TabIndex = 1;
            this.qrGroup.TabStop = false;
            this.qrGroup.Text = "QR코드";
            // 
            // qrImage
            // 
            this.qrImage.Image = ((System.Drawing.Image)(resources.GetObject("qrImage.Image")));
            this.qrImage.Location = new System.Drawing.Point(36, 52);
            this.qrImage.Name = "qrImage";
            this.qrImage.Size = new System.Drawing.Size(200, 200);
            this.qrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrImage.TabIndex = 0;
            this.qrImage.TabStop = false;
            // 
            // loginGroup
            // 
            this.loginGroup.Controls.Add(this.loginButton);
            this.loginGroup.Controls.Add(this.pwLabel);
            this.loginGroup.Controls.Add(this.idLabel);
            this.loginGroup.Controls.Add(this.pwInputBox);
            this.loginGroup.Controls.Add(this.idInputBox);
            this.loginGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.loginGroup.Location = new System.Drawing.Point(332, 100);
            this.loginGroup.Name = "loginGroup";
            this.loginGroup.Size = new System.Drawing.Size(493, 275);
            this.loginGroup.TabIndex = 2;
            this.loginGroup.TabStop = false;
            this.loginGroup.Text = "개인정보 인증";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(356, 85);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 119);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(20, 163);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(117, 37);
            this.pwLabel.TabIndex = 2;
            this.pwLabel.Text = "생년월일";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(41, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(67, 37);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "학번";
            // 
            // pwInputBox
            // 
            this.pwInputBox.Location = new System.Drawing.Point(152, 160);
            this.pwInputBox.MaxLength = 6;
            this.pwInputBox.Name = "pwInputBox";
            this.pwInputBox.Size = new System.Drawing.Size(181, 44);
            this.pwInputBox.TabIndex = 0;
            this.pwInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idInputBox
            // 
            this.idInputBox.Location = new System.Drawing.Point(152, 85);
            this.idInputBox.MaxLength = 4;
            this.idInputBox.Name = "idInputBox";
            this.idInputBox.Size = new System.Drawing.Size(181, 44);
            this.idInputBox.TabIndex = 0;
            this.idInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnButton.Location = new System.Drawing.Point(20, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(50, 35);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "←";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 475);
            this.ControlBox = false;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.loginGroup);
            this.Controls.Add(this.qrGroup);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "로그인";
            this.qrGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrImage)).EndInit();
            this.loginGroup.ResumeLayout(false);
            this.loginGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox qrGroup;
        private System.Windows.Forms.PictureBox qrImage;
        private System.Windows.Forms.GroupBox loginGroup;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idInputBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.TextBox pwInputBox;
        private System.Windows.Forms.Button returnButton;
    }
}