using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winform_6
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            button_Save.PerformClick();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            int x = mousePosition.X;
            int y = mousePosition.Y;
            // 저장한 좌표를 사용해 원하는 작업을 수행하면 됩니다.
            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
      
        }

        private void button_End_Click(object sender, EventArgs e)
        {

        }

        private void Auto_Mouse_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                // 실시간 마우스 좌표 저장
                button_Save.PerformClick();
            }
        }
    }
}
