namespace Winform_4
{
    partial class Mainfrom
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu_box = new System.Windows.Forms.GroupBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.Food_box = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check_menu = new System.Windows.Forms.GroupBox();
            this.other_check = new System.Windows.Forms.RadioButton();
            this.jp_check = new System.Windows.Forms.RadioButton();
            this.west_check = new System.Windows.Forms.RadioButton();
            this.ch_check = new System.Windows.Forms.RadioButton();
            this.K_check = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.upload_button = new System.Windows.Forms.Button();
            this.Menu_box.SuspendLayout();
            this.Food_box.SuspendLayout();
            this.check_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_box
            // 
            this.Menu_box.Controls.Add(this.upload_button);
            this.Menu_box.Controls.Add(this.submit_button);
            this.Menu_box.Controls.Add(this.Food_box);
            this.Menu_box.Controls.Add(this.check_menu);
            this.Menu_box.Controls.Add(this.label6);
            this.Menu_box.Font = new System.Drawing.Font("굴림", 10F);
            this.Menu_box.Location = new System.Drawing.Point(33, 24);
            this.Menu_box.Name = "Menu_box";
            this.Menu_box.Size = new System.Drawing.Size(438, 641);
            this.Menu_box.TabIndex = 5;
            this.Menu_box.TabStop = false;
            this.Menu_box.Text = "Choise !";
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
            this.Food_box.Controls.Add(this.label5);
            this.Food_box.Controls.Add(this.label4);
            this.Food_box.Controls.Add(this.label3);
            this.Food_box.Controls.Add(this.label2);
            this.Food_box.Controls.Add(this.label1);
            this.Food_box.Location = new System.Drawing.Point(113, 172);
            this.Food_box.Name = "Food_box";
            this.Food_box.Size = new System.Drawing.Size(98, 288);
            this.Food_box.TabIndex = 7;
            this.Food_box.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(22, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "기타";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(22, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "일식";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "양식";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "중식";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "한식";
            // 
            // check_menu
            // 
            this.check_menu.Controls.Add(this.other_check);
            this.check_menu.Controls.Add(this.jp_check);
            this.check_menu.Controls.Add(this.west_check);
            this.check_menu.Controls.Add(this.ch_check);
            this.check_menu.Controls.Add(this.K_check);
            this.check_menu.Location = new System.Drawing.Point(237, 172);
            this.check_menu.Name = "check_menu";
            this.check_menu.Size = new System.Drawing.Size(62, 288);
            this.check_menu.TabIndex = 6;
            this.check_menu.TabStop = false;
            this.check_menu.Enter += new System.EventHandler(this.check_menu_Enter);
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
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(22, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "어떤 분류를 추천 받고 싶으신가요?";
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(279, 602);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(159, 33);
            this.upload_button.TabIndex = 9;
            this.upload_button.Text = "음식 추가하기";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mainfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Menu_box);
            this.Name = "Mainfrom";
            this.Text = "MainForm";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox check_menu;
        private System.Windows.Forms.RadioButton other_check;
        private System.Windows.Forms.RadioButton jp_check;
        private System.Windows.Forms.RadioButton west_check;
        private System.Windows.Forms.RadioButton ch_check;
        private System.Windows.Forms.RadioButton K_check;
        private System.Windows.Forms.GroupBox Food_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button upload_button;
    }
}

