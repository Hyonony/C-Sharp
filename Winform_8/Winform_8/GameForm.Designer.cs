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
            this.StartButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Target = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(77, 86);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 33);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(615, 93);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(68, 18);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "          ";
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
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(63, 343);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(96, 73);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "GameForm";
            this.Text = "게임 화면";
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}