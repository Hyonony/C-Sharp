namespace Winform_8
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Target = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.RemainingPlaysLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreLabel.Location = new System.Drawing.Point(634, 94);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(85, 20);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "score : 0";
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.Target);
            this.GamePanel.Controls.Add(this.Ball);
            this.GamePanel.Location = new System.Drawing.Point(77, 137);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(648, 581);
            this.GamePanel.TabIndex = 2;
            // 
            // Target
            // 
            this.Target.Image = ((System.Drawing.Image)(resources.GetObject("Target.Image")));
            this.Target.Location = new System.Drawing.Point(199, 343);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(96, 73);
            this.Target.TabIndex = 1;
            this.Target.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(63, 343);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(96, 73);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // RemainingPlaysLabel
            // 
            this.RemainingPlaysLabel.AutoSize = true;
            this.RemainingPlaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemainingPlaysLabel.Location = new System.Drawing.Point(462, 95);
            this.RemainingPlaysLabel.Name = "RemainingPlaysLabel";
            this.RemainingPlaysLabel.Size = new System.Drawing.Size(132, 20);
            this.RemainingPlaysLabel.TabIndex = 3;
            this.RemainingPlaysLabel.Text = "남은 횟수 : 10 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(74, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "스페이스바를 이용하여 타켓을 맞추세요!";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemainingPlaysLabel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "GameForm";
            this.Text = "게임 화면";
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label RemainingPlaysLabel;
        private System.Windows.Forms.Label label1;
    }
}