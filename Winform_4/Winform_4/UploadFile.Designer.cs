namespace Winform_4
{
    partial class UploadFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.korea_radio = new System.Windows.Forms.RadioButton();
            this.china_radio = new System.Windows.Forms.RadioButton();
            this.japan_radio = new System.Windows.Forms.RadioButton();
            this.west_radio = new System.Windows.Forms.RadioButton();
            this.other_radio = new System.Windows.Forms.RadioButton();
            this.Food_name = new System.Windows.Forms.TextBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "타입 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.upload_button);
            this.groupBox1.Controls.Add(this.Food_name);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 업로드";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_radio);
            this.groupBox2.Controls.Add(this.west_radio);
            this.groupBox2.Controls.Add(this.japan_radio);
            this.groupBox2.Controls.Add(this.china_radio);
            this.groupBox2.Controls.Add(this.korea_radio);
            this.groupBox2.Location = new System.Drawing.Point(70, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // korea_radio
            // 
            this.korea_radio.AutoSize = true;
            this.korea_radio.Location = new System.Drawing.Point(6, 16);
            this.korea_radio.Name = "korea_radio";
            this.korea_radio.Size = new System.Drawing.Size(69, 22);
            this.korea_radio.TabIndex = 0;
            this.korea_radio.TabStop = true;
            this.korea_radio.Text = "한식";
            this.korea_radio.UseVisualStyleBackColor = true;
            // 
            // china_radio
            // 
            this.china_radio.AutoSize = true;
            this.china_radio.Location = new System.Drawing.Point(81, 16);
            this.china_radio.Name = "china_radio";
            this.china_radio.Size = new System.Drawing.Size(69, 22);
            this.china_radio.TabIndex = 1;
            this.china_radio.TabStop = true;
            this.china_radio.Text = "중식";
            this.china_radio.UseVisualStyleBackColor = true;
            // 
            // japan_radio
            // 
            this.japan_radio.AutoSize = true;
            this.japan_radio.Location = new System.Drawing.Point(156, 16);
            this.japan_radio.Name = "japan_radio";
            this.japan_radio.Size = new System.Drawing.Size(69, 22);
            this.japan_radio.TabIndex = 2;
            this.japan_radio.TabStop = true;
            this.japan_radio.Text = "일식";
            this.japan_radio.UseVisualStyleBackColor = true;
            // 
            // west_radio
            // 
            this.west_radio.AutoSize = true;
            this.west_radio.Location = new System.Drawing.Point(6, 54);
            this.west_radio.Name = "west_radio";
            this.west_radio.Size = new System.Drawing.Size(69, 22);
            this.west_radio.TabIndex = 3;
            this.west_radio.TabStop = true;
            this.west_radio.Text = "양식";
            this.west_radio.UseVisualStyleBackColor = true;
            // 
            // other_radio
            // 
            this.other_radio.AutoSize = true;
            this.other_radio.Location = new System.Drawing.Point(81, 54);
            this.other_radio.Name = "other_radio";
            this.other_radio.Size = new System.Drawing.Size(69, 22);
            this.other_radio.TabIndex = 4;
            this.other_radio.TabStop = true;
            this.other_radio.Text = "기타";
            this.other_radio.UseVisualStyleBackColor = true;
            // 
            // Food_name
            // 
            this.Food_name.Location = new System.Drawing.Point(70, 59);
            this.Food_name.Name = "Food_name";
            this.Food_name.Size = new System.Drawing.Size(253, 28);
            this.Food_name.TabIndex = 3;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(70, 226);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(89, 27);
            this.upload_button.TabIndex = 4;
            this.upload_button.Text = "업로드";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Img : ";
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupBox1);
            this.Name = "UploadFile";
            this.Text = "파일 업로드 창";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.TextBox Food_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton other_radio;
        private System.Windows.Forms.RadioButton west_radio;
        private System.Windows.Forms.RadioButton japan_radio;
        private System.Windows.Forms.RadioButton china_radio;
        private System.Windows.Forms.RadioButton korea_radio;
    }
}