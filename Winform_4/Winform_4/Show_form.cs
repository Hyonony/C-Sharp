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
        string connectionString = "Server=localhost;Database=DB_user;Uid=root;Pwd=root;";
        List<string> imagePaths = new List<string>();
        string query = "";

        public Show_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void right_button_Click(object sender, EventArgs e)
        {
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // 한식
            if (Mainfrom.typecheck == "1")
            {
                // MessageBox.Show("데이터가 적어서 한식 전체를 보여드리겠습니다.", "알림");
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
                //MessageBox.Show("데이터가 적어서 중식 전체를 보여드리겠습니다.", "알림");

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
                //MessageBox.Show("데이터가 적어서 일식 전체를 보여드리겠습니다.", "알림");

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
                //MessageBox.Show("데이터가 적어서 양식 전체를 보여드리겠습니다.", "알림");

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
                // MessageBox.Show("데이터가 적어서 기타 전체를 보여드리겠습니다.", "알림");

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
            /*
            MySqlCommand command = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["foodImage"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            */
            int currentImageId = int.Parse(lblImageId.Text);

            int nextImageId = currentImageId + 1;

            if (CheckIfImageExists(nextImageId))
            {
                // 다음 이미지가 존재하면 해당 이미지를 보여줍니다.
                ShowImageInPictureBox(nextImageId);
            }
            else
            {
                // 다음 이미지가 존재하지 않으면 첫 번째 이미지를 보여줍니다.
                ShowImageInPictureBox(1);
            }
        }
        private bool CheckIfImageExists(int imageId)
        {
            string connectionString = "Server=localhost;Database=DB_user;Uid=root;Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = $"SELECT COUNT(*) FROM food WHERE id = {imageId}";

            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            object result = null;
            if (command != null)
            {
                result = command.ExecuteScalar();
            }
            int count = result == null ? 0 : Convert.ToInt32(result);

            connection.Close();

            return (count > 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 첫 번째 이미지를 보여줍니다.
            ShowImageInPictureBox(1);

            // 이미지 ID값을 보여주는 Label 컨트롤에 1을 설정합니다.
            lblImageId.Text = "1";
        }
        private void ShowImageInPictureBox(int imageId)
        {
            string connectionString = "Server=localhost;Database=DB_user;Uid=root;Pwd=root;";
            string query = $"SELECT * FROM food WHERE id = {imageId}";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
        
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                byte[] imageBytes = (byte[])reader["foodImage"];
                MemoryStream ms = new MemoryStream(imageBytes);
                pictureBox1.Image = Image.FromStream(ms);

                // 현재 보여지고 있는 이미지의 ID값을 설정합니다.
                lblImageId.Text = imageId.ToString();
            }

            connection.Close();
            reader.Close();
        }

        

        private void lblImageId_Click(object sender, EventArgs e)
        {

        }
    }
}
