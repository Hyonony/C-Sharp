using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadWinFormExample
{
    public partial class MainForm : Form
    {
        private Thread calculationThread; // 계산 스레드를 저장하기 위한 변수
        private bool stopThread = false;

        public MainForm()
        {
            InitializeComponent();
        }


        private void CalculateNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (stopThread) // 스레드 중지 여부 확인
                    break;

                int result = i + i;

                // Invoke를 사용하여 ListBox의 쓰레드가 안전한 방식으로 아이템을 추가하도록 처리합니다.
                Invoke((MethodInvoker)delegate {
                    ResultListBox.Items.Add("Number: " + i + ", Result: " + result);
                });

                Thread.Sleep(1000); // 각 계산 후 1초 대기
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();
        }

        private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartThreadButton_Click_1(object sender, EventArgs e)
        {
            stopThread = false;
            calculationThread = new Thread(CalculateNumbers);
            calculationThread.Start();
        }

        private void StopThreadButton_Click(object sender, EventArgs e)
        {
            stopThread = true;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopThread = true; // 폼이 닫힐 때 스레드 중지 변수 설정
            if (calculationThread != null && calculationThread.IsAlive)
                calculationThread.Join(); // 스레드 종료 대기
        }
    }
}