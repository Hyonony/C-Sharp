using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_5
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Baseball_page(object sender, EventArgs e) //Baseball_click
        {
            BaseBallGame baseball = new BaseBallGame();
            this.Hide();

            DialogResult result = baseball.ShowDialog();


            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
