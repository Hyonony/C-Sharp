using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Winform_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trash_text_TextChanged(object sender, EventArgs e) //trash_text
        {
            
        }
    

        private void Throw_button_Click(object sender, EventArgs e) //Throw_button
        {
            Throw th = new Throw();
            DialogResult result = th.ShowDialog();
            // Form2 보여주기

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
