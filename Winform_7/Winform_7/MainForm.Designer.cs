namespace AutoSearchDirectory
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
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.Seach_Word = new System.Windows.Forms.TextBox();
            this.DIR_BUTTON = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.SavefileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(644, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 35);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SavefileButton);
            this.groupBox1.Controls.Add(this.FileOpenButton);
            this.groupBox1.Controls.Add(this.Seach_Word);
            this.groupBox1.Controls.Add(this.DIR_BUTTON);
            this.groupBox1.Controls.Add(this.resultListBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 743);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What do you Want to Search";
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Location = new System.Drawing.Point(520, 681);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(103, 35);
            this.FileOpenButton.TabIndex = 6;
            this.FileOpenButton.Text = "파일 열기";
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // Seach_Word
            // 
            this.Seach_Word.Location = new System.Drawing.Point(34, 51);
            this.Seach_Word.Name = "Seach_Word";
            this.Seach_Word.Size = new System.Drawing.Size(604, 28);
            this.Seach_Word.TabIndex = 5;
            this.Seach_Word.TextChanged += new System.EventHandler(this.searchWordTextBox_TextChanged);
            // 
            // DIR_BUTTON
            // 
            this.DIR_BUTTON.Location = new System.Drawing.Point(629, 681);
            this.DIR_BUTTON.Name = "DIR_BUTTON";
            this.DIR_BUTTON.Size = new System.Drawing.Size(103, 35);
            this.DIR_BUTTON.TabIndex = 4;
            this.DIR_BUTTON.Text = "폴더 경로";
            this.DIR_BUTTON.UseVisualStyleBackColor = true;
            this.DIR_BUTTON.Click += new System.EventHandler(this.DIR_BUTTON_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 18;
            this.resultListBox.Location = new System.Drawing.Point(34, 89);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(698, 580);
            this.resultListBox.TabIndex = 3;
            // 
            // SavefileButton
            // 
            this.SavefileButton.Location = new System.Drawing.Point(410, 681);
            this.SavefileButton.Name = "SavefileButton";
            this.SavefileButton.Size = new System.Drawing.Size(103, 35);
            this.SavefileButton.TabIndex = 7;
            this.SavefileButton.Text = "파일 저장";
            this.SavefileButton.UseVisualStyleBackColor = true;
            this.SavefileButton.Click += new System.EventHandler(this.SavefileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "파일 탐색 프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button DIR_BUTTON;
        private System.Windows.Forms.TextBox Seach_Word;
        private System.Windows.Forms.Button FileOpenButton;
        private System.Windows.Forms.Button SavefileButton;
    }
}

