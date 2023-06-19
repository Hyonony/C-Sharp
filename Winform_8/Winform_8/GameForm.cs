using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_8
{
    public partial class GameForm : Form
    {
        private int score = 0;
        private int direction = 1;
        private bool isMoving = false;

        public GameForm()
        {
            InitializeComponent();
            this.Load += GameForm_Load;

            this.KeyPreview = true;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += GameForm_KeyDown;
            StartTargetMovement();
            StartButton.Click += StartButton_Click;
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private async void StartTargetMovement()
        {
            while (true)
            {
                Target.Left += direction * 5;
                if (Target.Right > GamePanel.Width || Target.Left < 0)
                {
                    direction *= -1;
                }
                await Task.Delay(50);
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            isMoving = !isMoving;
            if (isMoving)
            {
                StartButton.Text = "정지";
            }
            else
            {
                StartButton.Text = "시작";
            }
        }

        private async void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isMoving)
            {
                Ball.Location = new Point(0, GamePanel.Height - Ball.Size.Height);

                while (Ball.Top > 0)
                {
                    await Task.Delay(50);
                    Ball.Top -= 10;

                    // Check for a collision with the Target
                    if (Ball.Bounds.IntersectsWith(Target.Bounds))
                    {
                        score++;
                        ScoreLabel.Text = "Score: " + score;
                        break;
                    }
                }

                Ball.Location = new Point(0, GamePanel.Height - Ball.Size.Height);
            }
        }
    }
}