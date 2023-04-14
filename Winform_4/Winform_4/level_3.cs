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
        public static string saltlevel;

        public level_3()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            
            Show_form showform = new Show_form();

            level_3 level3 = new level_3();


            if (salt_1_check.Checked)
            {
                saltlevel = "1";
            }
            else if (salt_2_check.Checked)
            {
                saltlevel = "2";
            }
            else if (salt_3_check.Checked)
            {
                saltlevel = "3";
            }
            else if (salt_4_check.Checked)
            {
                saltlevel = "4";
            }
            else if (salt_5_check.Checked)
            {
                saltlevel = "5";
            }
            // 현재 폼 숨기기
            this.Hide();

            DialogResult result = showform.ShowDialog();
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
