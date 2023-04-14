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
        public static string sweetlevel;

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
            Show_form showform = new Show_form();

            level_3 level3 = new level_3();


            if (sweet_1_check.Checked)
            {
                sweetlevel = "1";
            }
            else if (sweet_2_check.Checked)
            {
                sweetlevel = "2";
            }
            else if (sweet_3_check.Checked)
            {
                sweetlevel = "3";
            }
            else if (sweet_4_check.Checked)
            {
                sweetlevel = "4";
            }
            else if (sweet_5_check.Checked)
            {
                sweetlevel = "5";
            }

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
