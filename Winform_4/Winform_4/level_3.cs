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
    public partial class level_3 : Form
    {
        public level_3()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Show_form SF = new Show_form();

            // 현재 폼 숨기기
            this.Hide();

            DialogResult result = SF.ShowDialog();
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
