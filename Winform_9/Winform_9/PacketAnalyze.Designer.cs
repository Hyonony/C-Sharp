using System.Windows.Forms;

namespace Winform_9
{
    partial class PacketAnalyze
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
            this.deviceListComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.packetInfoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deviceListComboBox
            // 
            this.deviceListComboBox.FormattingEnabled = true;
            this.deviceListComboBox.Location = new System.Drawing.Point(12, 12);
            this.deviceListComboBox.Name = "deviceListComboBox";
            this.deviceListComboBox.Size = new System.Drawing.Size(278, 21);
            this.deviceListComboBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(307, 11);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(396, 11);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "중지";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // packetInfoListBox
            // 
            this.packetInfoListBox.FormattingEnabled = true;
            this.packetInfoListBox.Location = new System.Drawing.Point(12, 40);
            this.packetInfoListBox.Name = "packetInfoListBox";
            this.packetInfoListBox.Size = new System.Drawing.Size(459, 368);
            this.packetInfoListBox.TabIndex = 3;
            // 
            // PacketAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.packetInfoListBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.deviceListComboBox);
            this.Name = "PacketAnalyze";
            this.Text = "Packet Analyzer";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox deviceListComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox listBox1;
        private ListBox packetInfoListBox;
    }
}

