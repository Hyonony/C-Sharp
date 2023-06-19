using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadWinFormExample;

namespace Winform_8
{
    public partial class GameForm : Form
    {
        private int score = 0;
        private CancellationTokenSource cts;

        private MainForm mainForm;

        public GameForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
                cts.Dispose();
            }

            cts = new CancellationTokenSource();
            Task.Run(() => MoveTarget(cts.Token));
        }
        private async Task MoveTarget(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(50);
                Invoke(new Action(() =>
                {
                    Target.Left += 5;
                    if (Target.Right > GamePanel.Width || Target.Left < 0)
                    {
                        Target.Left -= 10;
                    }

                    // Check for a collision with the Ball
                    if (Ball.Bounds.IntersectsWith(Target.Bounds))
                    {
                        score++;
                        ScoreLabel.Text = "Score: " + score;
                        Ball.Location = new Point(0, 0);
                    }
                }));
            }
        }
        private async void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Ball.Location = new Point(0, GamePanel.Height - Ball.Size.Height);
                while (Ball.Top > 0)
                {
                    await Task.Delay(50); // pause for 50 milliseconds
                    Invoke(new Action(() => { Ball.Top -= 10; })); // move the ball
                }
                Ball.Location = new Point(0, GamePanel.Height - Ball.Size.Height); // reset the ball
            }
        }

    }
}