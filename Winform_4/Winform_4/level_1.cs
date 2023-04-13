using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_4
{
    public partial class level_1 : Form
    {
        public level_1()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            level_2 level2 = new level_2();

            // 현재 폼 숨기기
            this.Hide();

            DialogResult result = level2.ShowDialog();
            // Form2 보여주기

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
