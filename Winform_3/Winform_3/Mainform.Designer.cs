namespace Winform_3
{
    partial class MainForm
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
            this.trash_box = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Throw_button = new System.Windows.Forms.Button();
            this.trash_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // trash_box
            // 
            this.trash_box.Controls.Add(this.label2);
            this.trash_box.Controls.Add(this.Throw_button);
            this.trash_box.Font = new System.Drawing.Font("굴림", 8F);
            this.trash_box.Location = new System.Drawing.Point(38, 55);
            this.trash_box.Name = "trash_box";
            this.trash_box.Size = new System.Drawing.Size(440, 557);
            this.trash_box.TabIndex = 4;
            this.trash_box.TabStop = false;
            this.trash_box.Text = "분리수거를 하자!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(136, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "쓰레기통";
            // 
            // Throw_button
            // 
            this.Throw_button.Location = new System.Drawing.Point(114, 319);
            this.Throw_button.Name = "Throw_button";
            this.Throw_button.Size = new System.Drawing.Size(185, 73);
            this.Throw_button.TabIndex = 3;
            this.Throw_button.Text = "버리시겠습니까?";
            this.Throw_button.UseVisualStyleBackColor = true;
            this.Throw_button.Click += new System.EventHandler(this.Throw_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.trash_box);
            this.Name = "MainForm";
            this.Text = "감정 쓰레기통";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trash_box.ResumeLayout(false);
            this.trash_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox trash_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Throw_button;
    }
}

