namespace Winform_4
{
    partial class level_1
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
            this.hot_5 = new System.Windows.Forms.Label();
            this.hot_4 = new System.Windows.Forms.Label();
            this.hot_3 = new System.Windows.Forms.Label();
            this.hot_2 = new System.Windows.Forms.Label();
            this.hot_1 = new System.Windows.Forms.Label();
            this.check_menu = new System.Windows.Forms.GroupBox();
            this.hot_5_check = new System.Windows.Forms.RadioButton();
            this.hot_4_check = new System.Windows.Forms.RadioButton();
            this.hot_3_check = new System.Windows.Forms.RadioButton();
            this.hot_2_check = new System.Windows.Forms.RadioButton();
            this.hot_1_check = new System.Windows.Forms.RadioButton();
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
            this.Menu_box.TabIndex = 6;
            this.Menu_box.TabStop = false;
            this.Menu_box.Text = "Choise !";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(330, 593);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(102, 42);
            this.back_button.TabIndex = 9;
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
            this.Food_box.Controls.Add(this.hot_5);
            this.Food_box.Controls.Add(this.hot_4);
            this.Food_box.Controls.Add(this.hot_3);
            this.Food_box.Controls.Add(this.hot_2);
            this.Food_box.Controls.Add(this.hot_1);
            this.Food_box.Location = new System.Drawing.Point(83, 172);
            this.Food_box.Name = "Food_box";
            this.Food_box.Size = new System.Drawing.Size(154, 288);
            this.Food_box.TabIndex = 7;
            this.Food_box.TabStop = false;
            // 
            // hot_5
            // 
            this.hot_5.AutoSize = true;
            this.hot_5.Font = new System.Drawing.Font("굴림", 11F);
            this.hot_5.Location = new System.Drawing.Point(22, 238);
            this.hot_5.Name = "hot_5";
            this.hot_5.Size = new System.Drawing.Size(127, 22);
            this.hot_5.TabIndex = 9;
            this.hot_5.Text = "가장 안매움";
            // 
            // hot_4
            // 
            this.hot_4.AutoSize = true;
            this.hot_4.Font = new System.Drawing.Font("굴림", 11F);
            this.hot_4.Location = new System.Drawing.Point(22, 186);
            this.hot_4.Name = "hot_4";
            this.hot_4.Size = new System.Drawing.Size(83, 22);
            this.hot_4.TabIndex = 8;
            this.hot_4.Text = "안 매움";
            // 
            // hot_3
            // 
            this.hot_3.AutoSize = true;
            this.hot_3.Font = new System.Drawing.Font("굴림", 11F);
            this.hot_3.Location = new System.Drawing.Point(22, 134);
            this.hot_3.Name = "hot_3";
            this.hot_3.Size = new System.Drawing.Size(54, 22);
            this.hot_3.TabIndex = 7;
            this.hot_3.Text = "보통";
            // 
            // hot_2
            // 
            this.hot_2.AutoSize = true;
            this.hot_2.Font = new System.Drawing.Font("굴림", 11F);
            this.hot_2.Location = new System.Drawing.Point(22, 80);
            this.hot_2.Name = "hot_2";
            this.hot_2.Size = new System.Drawing.Size(54, 22);
            this.hot_2.TabIndex = 6;
            this.hot_2.Text = "매움";
            // 
            // hot_1
            // 
            this.hot_1.AutoSize = true;
            this.hot_1.Font = new System.Drawing.Font("굴림", 11F);
            this.hot_1.Location = new System.Drawing.Point(22, 28);
            this.hot_1.Name = "hot_1";
            this.hot_1.Size = new System.Drawing.Size(105, 22);
            this.hot_1.TabIndex = 5;
            this.hot_1.Text = "가장 매움";
            // 
            // check_menu
            // 
            this.check_menu.Controls.Add(this.hot_5_check);
            this.check_menu.Controls.Add(this.hot_4_check);
            this.check_menu.Controls.Add(this.hot_3_check);
            this.check_menu.Controls.Add(this.hot_2_check);
            this.check_menu.Controls.Add(this.hot_1_check);
            this.check_menu.Location = new System.Drawing.Point(276, 172);
            this.check_menu.Name = "check_menu";
            this.check_menu.Size = new System.Drawing.Size(62, 288);
            this.check_menu.TabIndex = 6;
            this.check_menu.TabStop = false;
            // 
            // hot_5_check
            // 
            this.hot_5_check.AutoSize = true;
            this.hot_5_check.Location = new System.Drawing.Point(17, 239);
            this.hot_5_check.Name = "hot_5_check";
            this.hot_5_check.Size = new System.Drawing.Size(21, 20);
            this.hot_5_check.TabIndex = 4;
            this.hot_5_check.TabStop = true;
            this.hot_5_check.UseVisualStyleBackColor = true;
            // 
            // hot_4_check
            // 
            this.hot_4_check.AutoSize = true;
            this.hot_4_check.Location = new System.Drawing.Point(17, 185);
            this.hot_4_check.Name = "hot_4_check";
            this.hot_4_check.Size = new System.Drawing.Size(21, 20);
            this.hot_4_check.TabIndex = 3;
            this.hot_4_check.TabStop = true;
            this.hot_4_check.UseVisualStyleBackColor = true;
            // 
            // hot_3_check
            // 
            this.hot_3_check.AutoSize = true;
            this.hot_3_check.Location = new System.Drawing.Point(17, 133);
            this.hot_3_check.Name = "hot_3_check";
            this.hot_3_check.Size = new System.Drawing.Size(21, 20);
            this.hot_3_check.TabIndex = 2;
            this.hot_3_check.TabStop = true;
            this.hot_3_check.UseVisualStyleBackColor = true;
            // 
            // hot_2_check
            // 
            this.hot_2_check.AutoSize = true;
            this.hot_2_check.Location = new System.Drawing.Point(17, 79);
            this.hot_2_check.Name = "hot_2_check";
            this.hot_2_check.Size = new System.Drawing.Size(21, 20);
            this.hot_2_check.TabIndex = 1;
            this.hot_2_check.TabStop = true;
            this.hot_2_check.UseVisualStyleBackColor = true;
            // 
            // hot_1_check
            // 
            this.hot_1_check.AutoSize = true;
            this.hot_1_check.Location = new System.Drawing.Point(17, 26);
            this.hot_1_check.Name = "hot_1_check";
            this.hot_1_check.Size = new System.Drawing.Size(21, 20);
            this.hot_1_check.TabIndex = 0;
            this.hot_1_check.TabStop = true;
            this.hot_1_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13F);
            this.label6.Location = new System.Drawing.Point(126, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "맵기 정도 선택";
            // 
            // level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Menu_box);
            this.Name = "level_1";
            this.Text = "level_1";
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
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.GroupBox Food_box;
        private System.Windows.Forms.Label hot_5;
        private System.Windows.Forms.Label hot_4;
        private System.Windows.Forms.Label hot_3;
        private System.Windows.Forms.Label hot_2;
        private System.Windows.Forms.Label hot_1;
        private System.Windows.Forms.GroupBox check_menu;
        private System.Windows.Forms.RadioButton hot_5_check;
        private System.Windows.Forms.RadioButton hot_4_check;
        private System.Windows.Forms.RadioButton hot_3_check;
        private System.Windows.Forms.RadioButton hot_2_check;
        private System.Windows.Forms.RadioButton hot_1_check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_button;
    }
}