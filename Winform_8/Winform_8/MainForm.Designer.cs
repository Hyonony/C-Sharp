namespace ThreadWinFormExample
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
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.StartThreadButton = new System.Windows.Forms.Button();
            this.StopThreadButton = new System.Windows.Forms.Button();
            this.MoveToGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 18;
            this.ResultListBox.Location = new System.Drawing.Point(74, 144);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(616, 274);
            this.ResultListBox.TabIndex = 0;
            this.ResultListBox.SelectedIndexChanged += new System.EventHandler(this.ResultListBox_SelectedIndexChanged);
            // 
            // StartThreadButton
            // 
            this.StartThreadButton.Location = new System.Drawing.Point(74, 97);
            this.StartThreadButton.Name = "StartThreadButton";
            this.StartThreadButton.Size = new System.Drawing.Size(90, 30);
            this.StartThreadButton.TabIndex = 1;
            this.StartThreadButton.Text = "Start";
            this.StartThreadButton.UseVisualStyleBackColor = true;
            this.StartThreadButton.Click += new System.EventHandler(this.StartThreadButton_Click_1);
            // 
            // StopThreadButton
            // 
            this.StopThreadButton.Location = new System.Drawing.Point(600, 97);
            this.StopThreadButton.Name = "StopThreadButton";
            this.StopThreadButton.Size = new System.Drawing.Size(90, 30);
            this.StopThreadButton.TabIndex = 2;
            this.StopThreadButton.Text = "Stop";
            this.StopThreadButton.UseVisualStyleBackColor = true;
            this.StopThreadButton.Click += new System.EventHandler(this.StopThreadButton_Click);
            // 
            // MoveToGameButton
            // 
            this.MoveToGameButton.Location = new System.Drawing.Point(600, 425);
            this.MoveToGameButton.Name = "MoveToGameButton";
            this.MoveToGameButton.Size = new System.Drawing.Size(90, 39);
            this.MoveToGameButton.TabIndex = 3;
            this.MoveToGameButton.Text = "Game";
            this.MoveToGameButton.UseVisualStyleBackColor = true;
            this.MoveToGameButton.Click += new System.EventHandler(this.MoveToGameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MoveToGameButton);
            this.Controls.Add(this.StopThreadButton);
            this.Controls.Add(this.StartThreadButton);
            this.Controls.Add(this.ResultListBox);
            this.Name = "MainForm";
            this.Text = "메인 화면";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button StartThreadButton;
        private System.Windows.Forms.Button StopThreadButton;
        private System.Windows.Forms.Button MoveToGameButton;
    }
}

