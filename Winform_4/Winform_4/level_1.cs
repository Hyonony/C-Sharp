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
        public static string hotlevel;

        public void submit_button_Click(object sender, EventArgs e)
        {
            Show_form showform = new Show_form();

            level_2 level2 = new level_2();
            
            if (hot_1_check.Checked)
            {
                hotlevel = "1";
            }
            else if (hot_2_check.Checked)
            {
                hotlevel = "2";
            }
            else if (hot_3_check.Checked)
            {
                hotlevel = "3";
            }
            else if (hot_4_check.Checked)
            {
                hotlevel = "4";
            }
            else if (hot_5_check.Checked)
            {
                hotlevel = "5";
            }




            // 현재 폼 숨기기
            this.Hide();

            DialogResult result = level2.ShowDialog();
            // Form2 보여주기

            this.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
