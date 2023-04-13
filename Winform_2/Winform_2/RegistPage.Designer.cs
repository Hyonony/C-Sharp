namespace Winform_2
{
    partial class Regist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.PW_text = new System.Windows.Forms.TextBox();
            this.PWC_text = new System.Windows.Forms.TextBox();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.add_num_text = new System.Windows.Forms.MaskedTextBox();
            this.Job_box = new System.Windows.Forms.ComboBox();
            this.phone_text = new System.Windows.Forms.MaskedTextBox();
            this.zen_check = new System.Windows.Forms.CheckedListBox();
            this.Register_label = new System.Windows.Forms.Label();
            this.regist_button = new System.Windows.Forms.Button();
            this.login_form = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ID_check = new System.Windows.Forms.Button();
            this.Open_PW = new System.Windows.Forms.CheckBox();
            this.Open_PWC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이 름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PW :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "PW(check) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "주소 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "직업 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "전화번호 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "성별 :";
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(156, 127);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(202, 28);
            this.Name_text.TabIndex = 8;
            this.Name_text.TextChanged += new System.EventHandler(this.Name_text_TextChanged);
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(156, 188);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(202, 28);
            this.ID_text.TabIndex = 9;
            this.ID_text.TextChanged += new System.EventHandler(this.ID_text_TextChanged);
            // 
            // PW_text
            // 
            this.PW_text.Location = new System.Drawing.Point(156, 252);
            this.PW_text.Name = "PW_text";
            this.PW_text.PasswordChar = '*';
            this.PW_text.Size = new System.Drawing.Size(202, 28);
            this.PW_text.TabIndex = 10;
            this.PW_text.TextChanged += new System.EventHandler(this.PW_text_TextChanged);
            // 
            // PWC_text
            // 
            this.PWC_text.Location = new System.Drawing.Point(156, 314);
            this.PWC_text.Name = "PWC_text";
            this.PWC_text.PasswordChar = '*';
            this.PWC_text.Size = new System.Drawing.Size(202, 28);
            this.PWC_text.TabIndex = 11;
            this.PWC_text.TextChanged += new System.EventHandler(this.PWC_text_TextChanged);
            // 
            // Address_text
            // 
            this.Address_text.Location = new System.Drawing.Point(156, 379);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(202, 28);
            this.Address_text.TabIndex = 12;
            this.Address_text.TextChanged += new System.EventHandler(this.Address_text_TextChanged);
            // 
            // add_num_text
            // 
            this.add_num_text.Location = new System.Drawing.Point(156, 443);
            this.add_num_text.Mask = "00000";
            this.add_num_text.Name = "add_num_text";
            this.add_num_text.Size = new System.Drawing.Size(202, 28);
            this.add_num_text.TabIndex = 13;
            this.add_num_text.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.add_num_text_MaskInputRejected);
            // 
            // Job_box
            // 
            this.Job_box.FormattingEnabled = true;
            this.Job_box.Items.AddRange(new object[] {
            "학생",
            "주부",
            "의사",
            "모델",
            "마술사",
            "만화가",
            "비행기 조종사",
            "반려동물 행동상담원",
            "연예인",
            "개발자",
            "유튜버"});
            this.Job_box.Location = new System.Drawing.Point(156, 498);
            this.Job_box.Name = "Job_box";
            this.Job_box.Size = new System.Drawing.Size(202, 26);
            this.Job_box.TabIndex = 14;
            this.Job_box.SelectedIndexChanged += new System.EventHandler(this.Job_box_SelectedIndexChanged);
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(156, 557);
            this.phone_text.Mask = "999-9000-0000";
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(202, 28);
            this.phone_text.TabIndex = 15;
            this.phone_text.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phone_text_MaskInputRejected);
            // 
            // zen_check
            // 
            this.zen_check.FormattingEnabled = true;
            this.zen_check.Items.AddRange(new object[] {
            "남성",
            "여성",
            "내시"});
            this.zen_check.Location = new System.Drawing.Point(156, 623);
            this.zen_check.Name = "zen_check";
            this.zen_check.Size = new System.Drawing.Size(202, 73);
            this.zen_check.TabIndex = 16;
            this.zen_check.SelectedIndexChanged += new System.EventHandler(this.zen_check_SelectedIndexChanged);
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("궁서체", 20F);
            this.Register_label.Location = new System.Drawing.Point(164, 46);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(177, 40);
            this.Register_label.TabIndex = 17;
            this.Register_label.Text = "회원가입";
            // z
            // regist_button
            // 
            this.regist_button.Font = new System.Drawing.Font("굴림", 12F);
            this.regist_button.Location = new System.Drawing.Point(171, 732);
            this.regist_button.Name = "regist_button";
            this.regist_button.Size = new System.Drawing.Size(170, 44);
            this.regist_button.TabIndex = 18;
            this.regist_button.Text = "회원가입";
            this.regist_button.UseVisualStyleBackColor = true;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // login_form
            // 
            this.login_form.Location = new System.Drawing.Point(397, 710);
            this.login_form.Name = "login_form";
            this.login_form.Size = new System.Drawing.Size(79, 66);
            this.login_form.TabIndex = 19;
            this.login_form.Text = "로그인";
            this.login_form.UseVisualStyleBackColor = true;
            this.login_form.Click += new System.EventHandler(this.login_form_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "우편번호 :";
            // 
            // ID_check
            // 
            this.ID_check.Location = new System.Drawing.Point(377, 186);
            this.ID_check.Name = "ID_check";
            this.ID_check.Size = new System.Drawing.Size(99, 30);
            this.ID_check.TabIndex = 21;
            this.ID_check.Text = "중복확인";
            this.ID_check.UseVisualStyleBackColor = true;
            this.ID_check.Click += new System.EventHandler(this.ID_check_Click);
            // 
            // Open_PW
            // 
            this.Open_PW.AutoSize = true;
            this.Open_PW.Location = new System.Drawing.Point(364, 256);
            this.Open_PW.Name = "Open_PW";
            this.Open_PW.Size = new System.Drawing.Size(120, 22);
            this.Open_PW.TabIndex = 22;
            this.Open_PW.Text = "PW 보이기";
            this.Open_PW.UseVisualStyleBackColor = true;
            this.Open_PW.CheckedChanged += new System.EventHandler(this.Open_PW_CheckedChanged);
            // 
            // Open_PWC
            // 
            this.Open_PWC.AutoSize = true;
            this.Open_PWC.Location = new System.Drawing.Point(364, 317);
            this.Open_PWC.Name = "Open_PWC";
            this.Open_PWC.Size = new System.Drawing.Size(120, 22);
            this.Open_PWC.TabIndex = 23;
            this.Open_PWC.Text = "PW 보이기";
            this.Open_PWC.UseVisualStyleBackColor = true;
            this.Open_PWC.CheckedChanged += new System.EventHandler(this.Open_PWC_CheckedChanged);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.Open_PWC);
            this.Controls.Add(this.Open_PW);
            this.Controls.Add(this.ID_check);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.login_form);
            this.Controls.Add(this.regist_button);
            this.Controls.Add(this.Register_label);
            this.Controls.Add(this.zen_check);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.Job_box);
            this.Controls.Add(this.add_num_text);
            this.Controls.Add(this.Address_text);
            this.Controls.Add(this.PWC_text);
            this.Controls.Add(this.PW_text);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Regist";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.TextBox PW_text;
        private System.Windows.Forms.TextBox PWC_text;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.MaskedTextBox add_num_text;
        private System.Windows.Forms.ComboBox Job_box;
        private System.Windows.Forms.MaskedTextBox phone_text;
        private System.Windows.Forms.CheckedListBox zen_check;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Button regist_button;
        private System.Windows.Forms.Button login_form;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ID_check;
        private System.Windows.Forms.CheckBox Open_PW;
        private System.Windows.Forms.CheckBox Open_PWC;
    }
}

