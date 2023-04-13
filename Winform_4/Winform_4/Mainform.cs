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
        public Mainfrom()
        {
            InitializeComponent();
        }

        private void check_menu_Enter(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            level_1 level1 = new level_1();

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
