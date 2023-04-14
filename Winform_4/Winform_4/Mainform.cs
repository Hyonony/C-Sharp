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
    public partial class Mainfrom : Form
    {
        public static string typecheck;
        public Mainfrom()
        {
            InitializeComponent();
        }

        private void check_menu_Enter(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Show_form showform = new Show_form();

            level_1 level1 = new level_1();


            if (K_check.Checked)
            {
                typecheck = "1";
            }
            else if (ch_check.Checked)
            {
                typecheck = "2";
            }
            else if (jp_check.Checked)
            {
                typecheck = "3";
            }
            else if (west_check.Checked)
            {
                typecheck = "4";
            }
            else if (other_check.Checked)
            {
                typecheck = "5";
            }



            this.Hide();
            DialogResult result = level1.ShowDialog();
            // Form2 보여주기

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadFile uplodefile = new UploadFile();

           
            DialogResult result = uplodefile.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
