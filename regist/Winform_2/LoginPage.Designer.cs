namespace Winform_2
{
    partial class LoginPage
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
            this.PW_text = new System.Windows.Forms.TextBox();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.regist_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PW_text
            // 
            this.PW_text.Location = new System.Drawing.Point(152, 266);
            this.PW_text.Name = "PW_text";
            this.PW_text.PasswordChar = '*';
            this.PW_text.Size = new System.Drawing.Size(202, 28);
            this.PW_text.TabIndex = 14;
            this.PW_text.TextChanged += new System.EventHandler(this.PW_text_TextChanged);
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(152, 202);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(202, 28);
            this.ID_text.TabIndex = 13;
            this.ID_text.TextChanged += new System.EventHandler(this.ID_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "PW :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID :";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(162, 338);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(160, 45);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.Login_Button);
            // 
            // regist_button
            // 
            this.regist_button.Font = new System.Drawing.Font("굴림", 10F);
            this.regist_button.Location = new System.Drawing.Point(286, 438);
            this.regist_button.Name = "regist_button";
            this.regist_button.Size = new System.Drawing.Size(137, 39);
            this.regist_button.TabIndex = 19;
            this.regist_button.Text = "회원가입";
            this.regist_button.UseVisualStyleBackColor = true;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.regist_button);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PW_text);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LoginPage";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PW_text;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button regist_button;
    }
}