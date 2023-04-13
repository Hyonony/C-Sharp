namespace Winform_2
{
    partial class duplication
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
            this.Check_Button = new System.Windows.Forms.Button();
            this.Use_button = new System.Windows.Forms.Button();
            this.out_Button = new System.Windows.Forms.Button();
            this.ID_check_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check_Button
            // 
            this.Check_Button.Location = new System.Drawing.Point(356, 104);
            this.Check_Button.Name = "Check_Button";
            this.Check_Button.Size = new System.Drawing.Size(100, 33);
            this.Check_Button.TabIndex = 0;
            this.Check_Button.Text = "중복 검사";
            this.Check_Button.UseVisualStyleBackColor = true;
            this.Check_Button.Click += new System.EventHandler(this.Check_Button_Click);
            // 
            // Use_button
            // 
            this.Use_button.Enabled = false;
            this.Use_button.Location = new System.Drawing.Point(91, 189);
            this.Use_button.Name = "Use_button";
            this.Use_button.Size = new System.Drawing.Size(109, 41);
            this.Use_button.TabIndex = 1;
            this.Use_button.Text = "사용하기";
            this.Use_button.UseVisualStyleBackColor = true;
            this.Use_button.Click += new System.EventHandler(this.Use_button_Click);
            // 
            // out_Button
            // 
            this.out_Button.Location = new System.Drawing.Point(250, 189);
            this.out_Button.Name = "out_Button";
            this.out_Button.Size = new System.Drawing.Size(109, 41);
            this.out_Button.TabIndex = 2;
            this.out_Button.Text = "취소하기";
            this.out_Button.UseVisualStyleBackColor = true;
            this.out_Button.Click += new System.EventHandler(this.out_Button_Click);
            // 
            // ID_check_text
            // 
            this.ID_check_text.Font = new System.Drawing.Font("굴림", 11F);
            this.ID_check_text.Location = new System.Drawing.Point(121, 104);
            this.ID_check_text.Name = "ID_check_text";
            this.ID_check_text.Size = new System.Drawing.Size(218, 33);
            this.ID_check_text.TabIndex = 3;
            this.ID_check_text.TextChanged += new System.EventHandler(this.ID_check_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(59, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID :";
            // 
            // duplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_check_text);
            this.Controls.Add(this.out_Button);
            this.Controls.Add(this.Use_button);
            this.Controls.Add(this.Check_Button);
            this.Name = "duplication";
            this.Text = "ID 중복 검사";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check_Button;
        private System.Windows.Forms.Button Use_button;
        private System.Windows.Forms.Button out_Button;
        private System.Windows.Forms.TextBox ID_check_text;
        private System.Windows.Forms.Label label1;
    }
}