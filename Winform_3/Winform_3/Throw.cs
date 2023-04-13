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
    public partial class Throw : Form
    {
        public Throw()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=DB_user;Uid=root;Pwd=root;");
                connection.Open();


                string insertQuery = "INSERT INTO trash_box (name, message, grade) VALUES (@name, @message, @grade)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", textBox1.Text);
                    command.Parameters.AddWithValue("@message", textBox2.Text);
                    if (radioButton1.Checked)
                    {
                        command.Parameters.AddWithValue("@grade", radioButton1.Text);
                    }
                    else if (radioButton2.Checked)
                    {
                        command.Parameters.AddWithValue("@grade", radioButton2.Text);
                    }
                    else if (radioButton3.Checked)
                    {
                        command.Parameters.AddWithValue("@grade", radioButton3.Text);
                    }

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("쓰레기 투척 성공!!", "알림 !");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
