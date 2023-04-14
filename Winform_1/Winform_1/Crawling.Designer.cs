namespace Practice
{
    partial class Crawling
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
            this.Connect_button = new System.Windows.Forms.Button();
            this.Url_text = new System.Windows.Forms.TextBox();
            this.Url_label = new System.Windows.Forms.Label();
            this.Search_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(635, 78);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(121, 78);
            this.Connect_button.TabIndex = 0;
            this.Connect_button.Text = "Connection";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.connect_button);
            // 
            // Url_text
            // 
            this.Url_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Url_text.Font = new System.Drawing.Font("굴림", 14F);
            this.Url_text.Location = new System.Drawing.Point(55, 116);
            this.Url_text.Name = "Url_text";
            this.Url_text.Size = new System.Drawing.Size(557, 40);
            this.Url_text.TabIndex = 1;
            this.Url_text.TextChanged += new System.EventHandler(this.url_text);
            // 
            // Url_label
            // 
            this.Url_label.Location = new System.Drawing.Point(0, 0);
            this.Url_label.Name = "Url_label";
            this.Url_label.Size = new System.Drawing.Size(100, 23);
            this.Url_label.TabIndex = 0;
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Font = new System.Drawing.Font("굴림", 15F);
            this.Search_label.Location = new System.Drawing.Point(50, 48);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(243, 30);
            this.Search_label.TabIndex = 2;
            this.Search_label.Text = "구글 이미지 검색";
            this.Search_label.Click += new System.EventHandler(this.Search_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 346);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Crawling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Url_label);
            this.Controls.Add(this.Url_text);
            this.Controls.Add(this.Connect_button);
            this.Name = "Crawling";
            this.Text = "Crawling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.TextBox Url_text;
        private System.Windows.Forms.Label Url_label;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}