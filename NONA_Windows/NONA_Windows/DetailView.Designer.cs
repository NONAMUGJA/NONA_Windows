namespace NONA_Windows
{
    partial class DetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailView));
            this.returnButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pImageView = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.requestTradeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pImageView)).BeginInit();
            this.SuspendLayout();
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
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "←";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.titleLabel.Location = new System.Drawing.Point(90, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 44);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "상품 정보";
            // 
            // pImageView
            // 
            this.pImageView.ErrorImage = null;
            this.pImageView.InitialImage = ((System.Drawing.Image)(resources.GetObject("pImageView.InitialImage")));
            this.pImageView.Location = new System.Drawing.Point(21, 87);
            this.pImageView.Name = "pImageView";
            this.pImageView.Size = new System.Drawing.Size(475, 350);
            this.pImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImageView.TabIndex = 7;
            this.pImageView.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.productName.Location = new System.Drawing.Point(525, 87);
            this.productName.MaximumSize = new System.Drawing.Size(300, 37);
            this.productName.MinimumSize = new System.Drawing.Size(300, 37);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(300, 37);
            this.productName.TabIndex = 8;
            this.productName.Text = "품명";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.quantityLabel.Location = new System.Drawing.Point(525, 124);
            this.quantityLabel.MaximumSize = new System.Drawing.Size(300, 37);
            this.quantityLabel.MinimumSize = new System.Drawing.Size(300, 37);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(300, 37);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "개수";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.commentLabel.Location = new System.Drawing.Point(525, 161);
            this.commentLabel.MaximumSize = new System.Drawing.Size(300, 225);
            this.commentLabel.MinimumSize = new System.Drawing.Size(300, 225);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(300, 225);
            this.commentLabel.TabIndex = 8;
            this.commentLabel.Text = "코멘트";
            // 
            // requestTradeButton
            // 
            this.requestTradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.requestTradeButton.FlatAppearance.BorderSize = 0;
            this.requestTradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestTradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.requestTradeButton.Location = new System.Drawing.Point(532, 389);
            this.requestTradeButton.Name = "requestTradeButton";
            this.requestTradeButton.Size = new System.Drawing.Size(293, 48);
            this.requestTradeButton.TabIndex = 9;
            this.requestTradeButton.Text = "교환 신청 보내기";
            this.requestTradeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.requestTradeButton.UseVisualStyleBackColor = false;
            this.requestTradeButton.Click += new System.EventHandler(this.requestTradeButton_Click);
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 475);
            this.ControlBox = false;
            this.Controls.Add(this.requestTradeButton);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.pImageView);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DetailView";
            ((System.ComponentModel.ISupportInitialize)(this.pImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pImageView;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button requestTradeButton;
    }
}