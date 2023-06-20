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
        private bool isMoving = false;
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
            UpdateRemainingPlays();
        }
        private void UpdateRemainingPlays()
        {
            RemainingPlaysLabel.Text = $"남은 횟수: {numPlays}";
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


        private async void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && numPlays > 0)
            {
                numPlays--;
                UpdateRemainingPlays(); // 추가된 부분: 남은 게임 횟수를 업데이트합니다.

                if (isMoving)
                {
                    return;
                }
                isMoving = true;

                if (numPlays == 0)
                {
                    MessageBox.Show($"게임이 종료되었습니다. 최종 점수: {score}", "게임 종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numPlays = 10;
                    score = 0;
                    ScoreLabel.Text = $"Score: {score}";
                    UpdateRemainingPlays(); // 추가된 부분: 남은 게임 횟수를 업데이트합니다.
                }
                else
                {
                    while (Ball.Top > 0)
                    {
                        await Task.Delay(20);
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

                isMoving = false;
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