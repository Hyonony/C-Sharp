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
        private bool isGamePaused = true;
        private Random rand = new Random();

        public GameForm()
        {
            InitializeComponent();
            this.Load += GameForm_Load;

            this.KeyPreview = true;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += GameForm_KeyDown;
            CentreBall();
            StartTargetMovement();
            StartButton.Click += StartButton_Click;
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private async void StartTargetMovement()
        {
            int speed = 10; // 목표물 이동 속도
            while (true)
            {
                Target.Left += direction * speed;
                if (Target.Right > GamePanel.Width || Target.Left < 0)
                {
                    direction *= -1;

                    // 목표물의 새로운 랜덤 위치를 설정
                    int randomX = rand.Next(0, GamePanel.Width - Target.Width);
                    Target.Location = new Point(randomX, Target.Location.Y);
                }

                await Task.Delay(20); // 목표물 이동 딜레이
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isGamePaused = !isGamePaused;
            if (isGamePaused)
            {
                StartButton.Text = "시작";
            }
            else
            {
                StartButton.Text = "정지";
            }
        }

        private async void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isGamePaused)
            {
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
                CentreBall(); // Reset ball to the centre
            }
        }
        private void CentreBall()
        {
            int x = rand.Next(0, GamePanel.Width - Ball.Width); // 공의 초기 위치를 랜덤으로 설정
            int y = GamePanel.Height - Ball.Height;
            Ball.Location = new Point(x, y);
        }
    }
}