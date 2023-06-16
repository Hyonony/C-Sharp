using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadWinFormExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void CalculateNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = i * i;

                // Invoke를 사용하여 ListBox의 쓰레드가 안전한 방식으로소를 추가하도록 처리합니다.
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
            Thread newThread = new Thread(CalculateNumbers);
            newThread.Start();
        }
    }
}