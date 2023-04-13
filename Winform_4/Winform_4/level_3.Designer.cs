namespace Winform_4
{
    partial class level_3
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
            this.Menu_box = new System.Windows.Forms.GroupBox();
            this.back_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.Food_box = new System.Windows.Forms.GroupBox();
            this.solt_5 = new System.Windows.Forms.Label();
            this.solt_4 = new System.Windows.Forms.Label();
            this.solt_3 = new System.Windows.Forms.Label();
            this.solt_2 = new System.Windows.Forms.Label();
            this.solt_1 = new System.Windows.Forms.Label();
            this.check_menu = new System.Windows.Forms.GroupBox();
            this.other_check = new System.Windows.Forms.RadioButton();
            this.jp_check = new System.Windows.Forms.RadioButton();
            this.west_check = new System.Windows.Forms.RadioButton();
            this.ch_check = new System.Windows.Forms.RadioButton();
            this.K_check = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Menu_box.SuspendLayout();
            this.Food_box.SuspendLayout();
            this.check_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_box
            // 
            this.Menu_box.Controls.Add(this.back_button);
            this.Menu_box.Controls.Add(this.submit_button);
            this.Menu_box.Controls.Add(this.Food_box);
            this.Menu_box.Controls.Add(this.check_menu);
            this.Menu_box.Controls.Add(this.label6);
            this.Menu_box.Font = new System.Drawing.Font("굴림", 10F);
            this.Menu_box.Location = new System.Drawing.Point(31, 30);
            this.Menu_box.Name = "Menu_box";
            this.Menu_box.Size = new System.Drawing.Size(438, 641);
            this.Menu_box.TabIndex = 8;
            this.Menu_box.TabStop = false;
            this.Menu_box.Text = "Choise !";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(330, 593);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(102, 42);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "처음으로";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(113, 503);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(199, 61);
            this.submit_button.TabIndex = 8;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // Food_box
            // 
            this.Food_box.Controls.Add(this.solt_5);
            this.Food_box.Controls.Add(this.solt_4);
            this.Food_box.Controls.Add(this.solt_3);
            this.Food_box.Controls.Add(this.solt_2);
            this.Food_box.Controls.Add(this.solt_1);
            this.Food_box.Location = new System.Drawing.Point(83, 172);
            this.Food_box.Name = "Food_box";
            this.Food_box.Size = new System.Drawing.Size(160, 288);
            this.Food_box.TabIndex = 7;
            this.Food_box.TabStop = false;
            // 
            // solt_5
            // 
            this.solt_5.AutoSize = true;
            this.solt_5.Font = new System.Drawing.Font("굴림", 11F);
            this.solt_5.Location = new System.Drawing.Point(22, 238);
            this.solt_5.Name = "solt_5";
            this.solt_5.Size = new System.Drawing.Size(112, 22);
            this.solt_5.TabIndex = 9;
            this.solt_5.Text = "가장 안 짠";
            // 
            // solt_4
            // 
            this.solt_4.AutoSize = true;
            this.solt_4.Font = new System.Drawing.Font("굴림", 11F);
            this.solt_4.Location = new System.Drawing.Point(22, 186);
            this.solt_4.Name = "solt_4";
            this.solt_4.Size = new System.Drawing.Size(61, 22);
            this.solt_4.TabIndex = 8;
            this.solt_4.Text = "안 짠";
            // 
            // solt_3
            // 
            this.solt_3.AutoSize = true;
            this.solt_3.Font = new System.Drawing.Font("굴림", 11F);
            this.solt_3.Location = new System.Drawing.Point(22, 134);
            this.solt_3.Name = "solt_3";
            this.solt_3.Size = new System.Drawing.Size(54, 22);
            this.solt_3.TabIndex = 7;
            this.solt_3.Text = "보통";
            // 
            // solt_2
            // 
            this.solt_2.AutoSize = true;
            this.solt_2.Font = new System.Drawing.Font("굴림", 11F);
            this.solt_2.Location = new System.Drawing.Point(22, 80);
            this.solt_2.Name = "solt_2";
            this.solt_2.Size = new System.Drawing.Size(32, 22);
            this.solt_2.TabIndex = 6;
            this.solt_2.Text = "짠";
            // 
            // solt_1
            // 
            this.solt_1.AutoSize = true;
            this.solt_1.Font = new System.Drawing.Font("굴림", 11F);
            this.solt_1.Location = new System.Drawing.Point(22, 28);
            this.solt_1.Name = "solt_1";
            this.solt_1.Size = new System.Drawing.Size(83, 22);
            this.solt_1.TabIndex = 5;
            this.solt_1.Text = "가장 짠";
            // 
            // check_menu
            // 
            this.check_menu.Controls.Add(this.other_check);
            this.check_menu.Controls.Add(this.jp_check);
            this.check_menu.Controls.Add(this.west_check);
            this.check_menu.Controls.Add(this.ch_check);
            this.check_menu.Controls.Add(this.K_check);
            this.check_menu.Location = new System.Drawing.Point(276, 172);
            this.check_menu.Name = "check_menu";
            this.check_menu.Size = new System.Drawing.Size(62, 288);
            this.check_menu.TabIndex = 6;
            this.check_menu.TabStop = false;
            // 
            // other_check
            // 
            this.other_check.AutoSize = true;
            this.other_check.Location = new System.Drawing.Point(17, 239);
            this.other_check.Name = "other_check";
            this.other_check.Size = new System.Drawing.Size(21, 20);
            this.other_check.TabIndex = 4;
            this.other_check.TabStop = true;
            this.other_check.UseVisualStyleBackColor = true;
            // 
            // jp_check
            // 
            this.jp_check.AutoSize = true;
            this.jp_check.Location = new System.Drawing.Point(17, 185);
            this.jp_check.Name = "jp_check";
            this.jp_check.Size = new System.Drawing.Size(21, 20);
            this.jp_check.TabIndex = 3;
            this.jp_check.TabStop = true;
            this.jp_check.UseVisualStyleBackColor = true;
            // 
            // west_check
            // 
            this.west_check.AutoSize = true;
            this.west_check.Location = new System.Drawing.Point(17, 133);
            this.west_check.Name = "west_check";
            this.west_check.Size = new System.Drawing.Size(21, 20);
            this.west_check.TabIndex = 2;
            this.west_check.TabStop = true;
            this.west_check.UseVisualStyleBackColor = true;
            // 
            // ch_check
            // 
            this.ch_check.AutoSize = true;
            this.ch_check.Location = new System.Drawing.Point(17, 79);
            this.ch_check.Name = "ch_check";
            this.ch_check.Size = new System.Drawing.Size(21, 20);
            this.ch_check.TabIndex = 1;
            this.ch_check.TabStop = true;
            this.ch_check.UseVisualStyleBackColor = true;
            // 
            // K_check
            // 
            this.K_check.AutoSize = true;
            this.K_check.Location = new System.Drawing.Point(17, 26);
            this.K_check.Name = "K_check";
            this.K_check.Size = new System.Drawing.Size(21, 20);
            this.K_check.TabIndex = 0;
            this.K_check.TabStop = true;
            this.K_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13F);
            this.label6.Location = new System.Drawing.Point(126, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "짠 정도 선택";
            // 
            // level_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Menu_box);
            this.Name = "level_3";
            this.Text = "level_3";
            this.Menu_box.ResumeLayout(false);
            this.Menu_box.PerformLayout();
            this.Food_box.ResumeLayout(false);
            this.Food_box.PerformLayout();
            this.check_menu.ResumeLayout(false);
            this.check_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu_box;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.GroupBox Food_box;
        private System.Windows.Forms.Label solt_5;
        private System.Windows.Forms.Label solt_4;
        private System.Windows.Forms.Label solt_3;
        private System.Windows.Forms.Label solt_2;
        private System.Windows.Forms.Label solt_1;
        private System.Windows.Forms.GroupBox check_menu;
        private System.Windows.Forms.RadioButton other_check;
        private System.Windows.Forms.RadioButton jp_check;
        private System.Windows.Forms.RadioButton west_check;
        private System.Windows.Forms.RadioButton ch_check;
        private System.Windows.Forms.RadioButton K_check;
        private System.Windows.Forms.Label label6;
    }
}