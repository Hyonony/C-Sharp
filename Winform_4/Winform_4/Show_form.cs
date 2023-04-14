﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Winform_4
{

    public partial class Show_form : Form
    {

        public Show_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void right_button_Click(object sender, EventArgs e)
        {
            


            string connectionString = "Server=localhost;Database=DB_user;Uid=root;Pwd=root;";
            string query = "";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            if (Mainfrom.typecheck == "1")
            {
                query = "SELECT foodImage FROM food WHERE Food_type = '한식'"; //컬럼(매운, 달달, 짠)

            }
            if (Mainfrom.typecheck == "2")
            {
                query = "SELECT foodImage FROM food WHERE Food_type = '중식'"; //컬럼(매운, 달달, 짠)

            }
            if (Mainfrom.typecheck == "3")
            {
                query = "SELECT foodImage FROM food WHERE Food_type = '일식'"; //컬럼(매운, 달달, 짠)

            }
            if (Mainfrom.typecheck == "4")
            {
                query = "SELECT foodImage FROM food WHERE Food_type = '양식'"; //컬럼(매운, 달달, 짠)

            }
            if (Mainfrom.typecheck == "5")
            {
                query = "SELECT foodImage FROM food WHERE Food_type = '기타'"; //컬럼(매운, 달달, 짠)

            }

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                byte[] imageBytes = (byte[])reader["foodImage"];
                MemoryStream ms = new MemoryStream(imageBytes);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Mainfrom.typecheck);
            //MessageBox.Show(level_1.hotlevel);
            //MessageBox.Show(level_2.sweetlevel);
            //MessageBox.Show(level_3.saltlevel);


        }
    }
}
