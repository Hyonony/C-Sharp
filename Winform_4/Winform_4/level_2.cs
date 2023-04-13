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
    public partial class level_2 : Form
    {
        public level_2()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            level_3 level3 = new level_3();

            // 현재 폼 숨기기
            this.Hide();
            DialogResult result = level3.ShowDialog();
            // Form2 보여주기

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
