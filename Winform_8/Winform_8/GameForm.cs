using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_8
{
    public partial class GameForm : Form
    {
        private int score = 0;
        private int numPlays = 10;
        private int direction = 1;
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
            SetInitialTargetPosition();
            StartTargetMovement();
            StartButton.Click += StartButton_Click;
        }

        private void SetInitialTargetPosition()
        {
            int randomX = rand.Next(0, GamePanel.Width - Target.Width);
            Target.Location = new Point(randomX, 0);
        }

        private async void StartTargetMovement()
        {
            int speed = 10;
            while (true)
            {
                Target.Left += direction * speed;
                if (Target.Right > GamePanel.Width || Target.Left < 0)
                {
                    direction *= -1;

                    int randomX = rand.Next(0, GamePanel.Width - Target.Width);
                    Target.Location = new Point(randomX, 0);
                }

                await Task.Delay(20);
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
            if (e.KeyCode == Keys.Space && !isGamePaused && numPlays > 0)
            {
                numPlays--;

                if (numPlays == 0)
                {
                    MessageBox.Show($"게임이 종료되었습니다. 최종 점수: {score}", "게임 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numPlays = 10; // 다시 게임을 할 수 있게 횟수를 리셋
                    score = 0; // 점수 다시 0으로 초기화
                    ScoreLabel.Text = $"Score: {score}";
                }
                else
                {
                    while (Ball.Top > 0)
                    {
                        await Task.Delay(20); // 수정된 부분: 지연 시간을 줄였습니다.
                        Ball.Top -= 10;

                        if (Ball.Bounds.IntersectsWith(Target.Bounds))
                        {
                            score++;
                            ScoreLabel.Text = $"Score: {score}";
                            break;
                        }
                    }
                    CentreBall();
                }
            }
        }
        private void CentreBall()
        {
            int x = rand.Next(0, GamePanel.Width - Ball.Width);
            int y = GamePanel.Height - Ball.Height;
            Ball.Location = new Point(x, y);
        }
    }
}