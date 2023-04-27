using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_5
{
    public partial class BaseBallGame : Form
    {
        private int[] answer = new int[3]; // 3자리 숫자
        private int count = 0; // 시도 횟수

        public BaseBallGame()
        {
            InitializeComponent();
            GenerateAnswer(); // 정답 생성
        }
        private void GenerateAnswer()
        {
            // 중복되지 않는 0~9의 숫자로 이루어진 3자리 숫자 생성
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int num;
                do
                {
                    num = random.Next(0, 10);
                } while (Array.IndexOf(answer, num) != -1);
                answer[i] = num;

            }
        }

        private void Throw_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 3)
            {
                MessageBox.Show("3자리 숫자를 입력하세요.");
                return;
            }

            int[] input = new int[3];
            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(textBox1.Text[i].ToString());
            }

            int ball = 0;
            int strike = 0;
            for (int i = 0; i < 3; i++)
            {
                if (input[i] == answer[i])
                {
                    strike++;
                }
                else if (Array.IndexOf(answer, input[i]) != -1)
                {
                    ball++;
                }
            }

            count++;
            listBox1.Items.Add(string.Format("[{0}] {1}, {2}B {3}S", count, textBox1.Text, ball, strike));

            if (strike == 3)
            {
                MessageBox.Show("축하합니다. 정답을 맞췄습니다.");
                GenerateAnswer(); // 새로운 문제 출제
                count = 0; // 시도 횟수 초기화
                listBox1.Items.Clear(); // 리스트 박스 초기화
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter 키를 눌렀을 때 실행할 코드 작성
                if (textBox1.Text.Length != 3)
                {
                    MessageBox.Show("3자리 숫자를 입력하세요.");
                    return;
                }

                int[] input = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    input[i] = int.Parse(textBox1.Text[i].ToString());
                }

                int ball = 0;
                int strike = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (input[i] == answer[i])
                    {
                        strike++;
                    }
                    else if (Array.IndexOf(answer, input[i]) != -1)
                    {
                        ball++;
                    }
                }

                count++;
                listBox1.Items.Add(string.Format("[{0}] {1}, {2}B {3}S", count, textBox1.Text, ball, strike));

                if (strike == 3)
                {
                    MessageBox.Show("축하합니다. 정답을 맞췄습니다. 새로운 문제로 넘어갑니다 !");
                    GenerateAnswer(); // 새로운 문제 출제
                    count = 0; // 시도 횟수 초기화
                    listBox1.Items.Clear(); // 리스트 박스 초기화
                }

                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
