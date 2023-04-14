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
            this.label3 = new System.Windows.Forms.Label();
            this.upload_button = new System.Windows.Forms.Button();
            this.Food_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.other_radio = new System.Windows.Forms.RadioButton();
            this.west_radio = new System.Windows.Forms.RadioButton();
            this.japan_radio = new System.Windows.Forms.RadioButton();
            this.china_radio = new System.Windows.Forms.RadioButton();
            this.korea_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.spicy_5 = new System.Windows.Forms.RadioButton();
            this.spicy_4 = new System.Windows.Forms.RadioButton();
            this.spicy_3 = new System.Windows.Forms.RadioButton();
            this.spicy_2 = new System.Windows.Forms.RadioButton();
            this.spicy_1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sweet_5 = new System.Windows.Forms.RadioButton();
            this.sweet_4 = new System.Windows.Forms.RadioButton();
            this.sweet_3 = new System.Windows.Forms.RadioButton();
            this.sweet_2 = new System.Windows.Forms.RadioButton();
            this.sweet_1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.salty_5 = new System.Windows.Forms.RadioButton();
            this.salty_4 = new System.Windows.Forms.RadioButton();
            this.salty_3 = new System.Windows.Forms.RadioButton();
            this.salty_2 = new System.Windows.Forms.RadioButton();
            this.salty_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "음식 이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "음식 타입 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.upload_button);
            this.groupBox1.Controls.Add(this.Food_name);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 642);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 업로드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Img : ";
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(70, 400);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(117, 31);
            this.upload_button.TabIndex = 4;
            this.upload_button.Text = "업로드";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // Food_name
            // 
            this.Food_name.Location = new System.Drawing.Point(104, 59);
            this.Food_name.Name = "Food_name";
            this.Food_name.Size = new System.Drawing.Size(548, 28);
            this.Food_name.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.other_radio);
            this.groupBox2.Controls.Add(this.west_radio);
            this.groupBox2.Controls.Add(this.japan_radio);
            this.groupBox2.Controls.Add(this.china_radio);
            this.groupBox2.Controls.Add(this.korea_radio);
            this.groupBox2.Location = new System.Drawing.Point(104, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // other_radio
            // 
            this.other_radio.AutoSize = true;
            this.other_radio.Location = new System.Drawing.Point(306, 16);
            this.other_radio.Name = "other_radio";
            this.other_radio.Size = new System.Drawing.Size(69, 22);
            this.other_radio.TabIndex = 4;
            this.other_radio.TabStop = true;
            this.other_radio.Text = "기타";
            this.other_radio.UseVisualStyleBackColor = true;
            // 
            // west_radio
            // 
            this.west_radio.AutoSize = true;
            this.west_radio.Location = new System.Drawing.Point(231, 16);
            this.west_radio.Name = "west_radio";
            this.west_radio.Size = new System.Drawing.Size(69, 22);
            this.west_radio.TabIndex = 3;
            this.west_radio.TabStop = true;
            this.west_radio.Text = "양식";
            this.west_radio.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "맵기 정도 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.spicy_5);
            this.groupBox3.Controls.Add(this.spicy_4);
            this.groupBox3.Controls.Add(this.spicy_3);
            this.groupBox3.Controls.Add(this.spicy_2);
            this.groupBox3.Controls.Add(this.spicy_1);
            this.groupBox3.Location = new System.Drawing.Point(104, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // spicy_5
            // 
            this.spicy_5.AutoSize = true;
            this.spicy_5.Location = new System.Drawing.Point(372, 16);
            this.spicy_5.Name = "spicy_5";
            this.spicy_5.Size = new System.Drawing.Size(135, 22);
            this.spicy_5.TabIndex = 4;
            this.spicy_5.TabStop = true;
            this.spicy_5.Text = "가장 안 매운";
            this.spicy_5.UseVisualStyleBackColor = true;
            // 
            // spicy_4
            // 
            this.spicy_4.AutoSize = true;
            this.spicy_4.Location = new System.Drawing.Point(273, 16);
            this.spicy_4.Name = "spicy_4";
            this.spicy_4.Size = new System.Drawing.Size(93, 22);
            this.spicy_4.TabIndex = 3;
            this.spicy_4.TabStop = true;
            this.spicy_4.Text = "안 매운";
            this.spicy_4.UseVisualStyleBackColor = true;
            // 
            // spicy_3
            // 
            this.spicy_3.AutoSize = true;
            this.spicy_3.Location = new System.Drawing.Point(198, 16);
            this.spicy_3.Name = "spicy_3";
            this.spicy_3.Size = new System.Drawing.Size(69, 22);
            this.spicy_3.TabIndex = 2;
            this.spicy_3.TabStop = true;
            this.spicy_3.Text = "보통";
            this.spicy_3.UseVisualStyleBackColor = true;
            // 
            // spicy_2
            // 
            this.spicy_2.AutoSize = true;
            this.spicy_2.Location = new System.Drawing.Point(123, 16);
            this.spicy_2.Name = "spicy_2";
            this.spicy_2.Size = new System.Drawing.Size(69, 22);
            this.spicy_2.TabIndex = 1;
            this.spicy_2.TabStop = true;
            this.spicy_2.Text = "매운";
            this.spicy_2.UseVisualStyleBackColor = true;
            // 
            // spicy_1
            // 
            this.spicy_1.AutoSize = true;
            this.spicy_1.Location = new System.Drawing.Point(6, 16);
            this.spicy_1.Name = "spicy_1";
            this.spicy_1.Size = new System.Drawing.Size(111, 22);
            this.spicy_1.TabIndex = 0;
            this.spicy_1.TabStop = true;
            this.spicy_1.Text = "가장 매운";
            this.spicy_1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "달기 정도 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "짠 정도 : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sweet_5);
            this.groupBox4.Controls.Add(this.sweet_4);
            this.groupBox4.Controls.Add(this.sweet_3);
            this.groupBox4.Controls.Add(this.sweet_2);
            this.groupBox4.Controls.Add(this.sweet_1);
            this.groupBox4.Location = new System.Drawing.Point(104, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // sweet_5
            // 
            this.sweet_5.AutoSize = true;
            this.sweet_5.Location = new System.Drawing.Point(372, 16);
            this.sweet_5.Name = "sweet_5";
            this.sweet_5.Size = new System.Drawing.Size(135, 22);
            this.sweet_5.TabIndex = 4;
            this.sweet_5.TabStop = true;
            this.sweet_5.Text = "가장 안 달달";
            this.sweet_5.UseVisualStyleBackColor = true;
            // 
            // sweet_4
            // 
            this.sweet_4.AutoSize = true;
            this.sweet_4.Location = new System.Drawing.Point(273, 16);
            this.sweet_4.Name = "sweet_4";
            this.sweet_4.Size = new System.Drawing.Size(93, 22);
            this.sweet_4.TabIndex = 3;
            this.sweet_4.TabStop = true;
            this.sweet_4.Text = "안 달달";
            this.sweet_4.UseVisualStyleBackColor = true;
            // 
            // sweet_3
            // 
            this.sweet_3.AutoSize = true;
            this.sweet_3.Location = new System.Drawing.Point(198, 16);
            this.sweet_3.Name = "sweet_3";
            this.sweet_3.Size = new System.Drawing.Size(69, 22);
            this.sweet_3.TabIndex = 2;
            this.sweet_3.TabStop = true;
            this.sweet_3.Text = "보통";
            this.sweet_3.UseVisualStyleBackColor = true;
            // 
            // sweet_2
            // 
            this.sweet_2.AutoSize = true;
            this.sweet_2.Location = new System.Drawing.Point(123, 16);
            this.sweet_2.Name = "sweet_2";
            this.sweet_2.Size = new System.Drawing.Size(69, 22);
            this.sweet_2.TabIndex = 1;
            this.sweet_2.TabStop = true;
            this.sweet_2.Text = "달달";
            this.sweet_2.UseVisualStyleBackColor = true;
            // 
            // sweet_1
            // 
            this.sweet_1.AutoSize = true;
            this.sweet_1.Location = new System.Drawing.Point(6, 16);
            this.sweet_1.Name = "sweet_1";
            this.sweet_1.Size = new System.Drawing.Size(111, 22);
            this.sweet_1.TabIndex = 0;
            this.sweet_1.TabStop = true;
            this.sweet_1.Text = "가장 달달";
            this.sweet_1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.salty_5);
            this.groupBox5.Controls.Add(this.salty_4);
            this.groupBox5.Controls.Add(this.salty_3);
            this.groupBox5.Controls.Add(this.salty_2);
            this.groupBox5.Controls.Add(this.salty_1);
            this.groupBox5.Location = new System.Drawing.Point(104, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 52);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // salty_5
            // 
            this.salty_5.AutoSize = true;
            this.salty_5.Location = new System.Drawing.Point(372, 16);
            this.salty_5.Name = "salty_5";
            this.salty_5.Size = new System.Drawing.Size(117, 22);
            this.salty_5.TabIndex = 4;
            this.salty_5.TabStop = true;
            this.salty_5.Text = "가장 안 짠";
            this.salty_5.UseVisualStyleBackColor = true;
            // 
            // salty_4
            // 
            this.salty_4.AutoSize = true;
            this.salty_4.Location = new System.Drawing.Point(273, 16);
            this.salty_4.Name = "salty_4";
            this.salty_4.Size = new System.Drawing.Size(75, 22);
            this.salty_4.TabIndex = 3;
            this.salty_4.TabStop = true;
            this.salty_4.Text = "안 짠";
            this.salty_4.UseVisualStyleBackColor = true;
            // 
            // salty_3
            // 
            this.salty_3.AutoSize = true;
            this.salty_3.Location = new System.Drawing.Point(198, 16);
            this.salty_3.Name = "salty_3";
            this.salty_3.Size = new System.Drawing.Size(69, 22);
            this.salty_3.TabIndex = 2;
            this.salty_3.TabStop = true;
            this.salty_3.Text = "보통";
            this.salty_3.UseVisualStyleBackColor = true;
            // 
            // salty_2
            // 
            this.salty_2.AutoSize = true;
            this.salty_2.Location = new System.Drawing.Point(123, 16);
            this.salty_2.Name = "salty_2";
            this.salty_2.Size = new System.Drawing.Size(51, 22);
            this.salty_2.TabIndex = 1;
            this.salty_2.TabStop = true;
            this.salty_2.Text = "짠";
            this.salty_2.UseVisualStyleBackColor = true;
            // 
            // salty_1
            // 
            this.salty_1.AutoSize = true;
            this.salty_1.Location = new System.Drawing.Point(6, 16);
            this.salty_1.Name = "salty_1";
            this.salty_1.Size = new System.Drawing.Size(93, 22);
            this.salty_1.TabIndex = 0;
            this.salty_1.TabStop = true;
            this.salty_1.Text = "가장 짠";
            this.salty_1.UseVisualStyleBackColor = true;
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "UploadFile";
            this.Text = "파일 업로드 창";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton spicy_5;
        private System.Windows.Forms.RadioButton spicy_4;
        private System.Windows.Forms.RadioButton spicy_3;
        private System.Windows.Forms.RadioButton spicy_2;
        private System.Windows.Forms.RadioButton spicy_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton salty_5;
        private System.Windows.Forms.RadioButton salty_4;
        private System.Windows.Forms.RadioButton salty_3;
        private System.Windows.Forms.RadioButton salty_2;
        private System.Windows.Forms.RadioButton salty_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton sweet_5;
        private System.Windows.Forms.RadioButton sweet_4;
        private System.Windows.Forms.RadioButton sweet_3;
        private System.Windows.Forms.RadioButton sweet_2;
        private System.Windows.Forms.RadioButton sweet_1;
    }
}