namespace Winform_5
{
    partial class Mainform
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
            this.Baseball_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baseball_click
            // 
            this.Baseball_click.Location = new System.Drawing.Point(94, 150);
            this.Baseball_click.Name = "Baseball_click";
            this.Baseball_click.Size = new System.Drawing.Size(93, 64);
            this.Baseball_click.TabIndex = 0;
            this.Baseball_click.Text = "BaseBall";
            this.Baseball_click.UseVisualStyleBackColor = true;
            this.Baseball_click.Click += new System.EventHandler(this.Baseball_page);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.Baseball_click);
            this.Name = "Mainform";
            this.Text = "메인 화면";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Baseball_click;
    }
}

