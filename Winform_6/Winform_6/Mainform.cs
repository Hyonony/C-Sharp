using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winform_6
{
    public partial class Mainform : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Mainform()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
          
        }

        private async void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;

            while(true)
            {
                // 현재 마우스 좌표를 가져옵니다.
                Point currentPosition = Cursor.Position;
             
                // 마우스 클릭 이벤트를 발생시킵니다.
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)currentPosition.X, (uint)currentPosition.Y, 0, 0);

                // 클릭 간격 시간만큼 대기합니다.
                int interval = Convert.ToInt32(1);
                await Task.Delay(interval);
                

                if(button_Start.Enabled == true)
                {
                    break;
                }
                
            }
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;

        }

        private void Auto_Mouse_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                Point currentPosition = Cursor.Position;

                int x = currentPosition.X;
                int y = currentPosition.Y;

                textBox1.Text = x.ToString();
                textBox2.Text = y.ToString();
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Start.Enabled = true;
            }
        }
    }
}
