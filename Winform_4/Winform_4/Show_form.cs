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

            // 한식
            if (Mainfrom.typecheck == "1")
            {
                // 매운 정도
                if(level_1.hotlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and spicy = '가장 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and spicy = '매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and spicy = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and spicy = '안 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and spicy = '가장 안 매운'"; //컬럼(매운, 달달, 짠)
                }

                // 달달한 정도
                if (level_2.sweetlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and sweet = '가장 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and sweet = '달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and sweet = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and sweet = '안 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and sweet = '가장 안 달달'"; //컬럼(매운, 달달, 짠)
                }

                // 짠 정도
                if (level_3.saltlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and salty = '가장 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and salty = '짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and salty = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and salty = '안 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '한식' and salty = '가장 안 짠'"; //컬럼(매운, 달달, 짠)
                }
            }

            // 중식
            else if (Mainfrom.typecheck == "2")
            {
                // 매운 정도
                if (level_1.hotlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and spicy = '가장 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and spicy = '매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and spicy = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and spicy = '안 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and spicy = '가장 안 매운'"; //컬럼(매운, 달달, 짠)
                }

                // 달달한 정도
                if (level_2.sweetlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and sweet = '가장 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and sweet = '달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and sweet = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and sweet = '안 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and sweet = '가장 안 달달'"; //컬럼(매운, 달달, 짠)
                }

                // 짠 정도
                if (level_3.saltlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and salty = '가장 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and salty = '짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and salty = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and salty = '안 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '중식' and salty = '가장 안 짠'"; //컬럼(매운, 달달, 짠)
                }

            }

            // 일식
            else if (Mainfrom.typecheck == "3")
            {
                if (level_1.hotlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and spicy = '가장 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and spicy = '매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and spicy = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and spicy = '안 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and spicy = '가장 안 매운'"; //컬럼(매운, 달달, 짠)
                }

                // 달달한 정도
                if (level_2.sweetlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and sweet = '가장 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and sweet = '달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and sweet = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and sweet = '안 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and sweet = '가장 안 달달'"; //컬럼(매운, 달달, 짠)
                }

                // 짠 정도
                if (level_3.saltlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and salty = '가장 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and salty = '짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and salty = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and salty = '안 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '일식' and salty = '가장 안 짠'"; //컬럼(매운, 달달, 짠)
                }

            }

            // 양식
            else if (Mainfrom.typecheck == "4")
            {
                if (level_1.hotlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and spicy = '가장 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and spicy = '매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and spicy = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and spicy = '안 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and spicy = '가장 안 매운'"; //컬럼(매운, 달달, 짠)
                }

                // 달달한 정도
                if (level_2.sweetlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and sweet = '가장 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and sweet = '달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and sweet = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and sweet = '안 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and sweet = '가장 안 달달'"; //컬럼(매운, 달달, 짠)
                }

                // 짠 정도
                if (level_3.saltlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and salty = '가장 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and salty = '짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and salty = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and salty = '안 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '양식' and salty = '가장 안 짠'"; //컬럼(매운, 달달, 짠)
                }

            }

            // 기타
            else if (Mainfrom.typecheck == "5")
            {
                if (level_1.hotlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and spicy = '가장 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and spicy = '매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and spicy = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and spicy = '안 매운'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_1.hotlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and spicy = '가장 안 매운'"; //컬럼(매운, 달달, 짠)
                }

                // 달달한 정도
                if (level_2.sweetlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and sweet = '가장 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and sweet = '달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and sweet = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and sweet = '안 달달'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_2.sweetlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and sweet = '가장 안 달달'"; //컬럼(매운, 달달, 짠)
                }

                // 짠 정도
                if (level_3.saltlevel == "1")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and salty = '가장 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "2")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and salty = '짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "3")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and salty = '보통'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "4")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and salty = '안 짠'"; //컬럼(매운, 달달, 짠)
                }
                else if (level_3.saltlevel == "5")
                {
                    query = "SELECT foodImage FROM food WHERE Food_type = '기타' and salty = '가장 안 짠'"; //컬럼(매운, 달달, 짠)
                }

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
