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
    public partial class UploadFile : Form
    {
        public UploadFile()
        {
            InitializeComponent();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            try
            {
                // OpenFileDialog 객체 생성
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // 이미지 파일 필터링
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // MySqlConnection 객체 생성
                    MySqlConnection conn = new MySqlConnection("Server=localhost;Database=DB_user;Uid=root;Pwd=root;");

                    // MySqlCommand 객체 생성
                    MySqlCommand cmd = new MySqlCommand();

                    // 쿼리문 작성
                    string query = "INSERT INTO food (food_name, foodImage, Food_type, spicy, salty, sweet) VALUES (@name, @image, @type, @spicy, @salty, @sweet)";

                    // MySqlCommand 객체에 쿼리문과 MySqlConnection 객체 할당
                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    // OpenFileDialog에서 선택한 이미지 파일을 바이너리 데이터로 변환하여 MySqlCommand 객체에 추가
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog1.FileName);
                    MySqlParameter imageParam = new MySqlParameter("@image", MySqlDbType.Blob, imageBytes.Length);
                    imageParam.Value = imageBytes;
                    cmd.Parameters.Add(imageParam);

                    // 나머지 파라미터 설정
                    cmd.Parameters.AddWithValue("@name", Food_name.Text);

                    // 지리별
                    if (korea_radio.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", korea_radio.Text);
                    }
                    else if (china_radio.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", china_radio.Text);
                    }
                    else if (japan_radio.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", japan_radio.Text);
                    }
                    else if (west_radio.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", west_radio.Text);
                    }
                    else if (other_radio.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", other_radio.Text);
                    }
                    // 매움
                    if (spicy_1.Checked)
                    {
                        cmd.Parameters.AddWithValue("@spicy", spicy_1.Text);
                    }
                    else if (spicy_2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@spicy", spicy_2.Text);
                    }
                    else if (spicy_3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@spicy", spicy_3.Text);
                    }
                    else if (spicy_4.Checked)
                    {
                        cmd.Parameters.AddWithValue("@spicy", spicy_4.Text);
                    }
                    else if (spicy_5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@spicy", spicy_5.Text);
                    }
                    
                    //달달
                    if (sweet_1.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sweet", sweet_1.Text);
                    }
                    else if (sweet_2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sweet", sweet_2.Text);
                    }
                    else if (sweet_3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sweet", sweet_3.Text);
                    }
                    else if (sweet_4.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sweet", sweet_4.Text);
                    }
                    else if (sweet_5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sweet", sweet_5.Text);
                    }
                    
                    //짠
                    if (salty_1.Checked)
                    {
                        cmd.Parameters.AddWithValue("@salty", salty_1.Text);
                    }
                    else if (salty_2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@salty", salty_2.Text);
                    }
                    else if (salty_3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@salty", salty_3.Text);
                    }
                    else if (salty_4.Checked)
                    {
                        cmd.Parameters.AddWithValue("@salty", salty_4.Text);
                    }
                    else if (salty_5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@salty", salty_5.Text);
                    }

                    // 데이터베이스에 연결하고 명령 실행
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("추천하신 음식이 올라갔습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("업로드 중 오류가 발생했습니다. 오류 메시지: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
