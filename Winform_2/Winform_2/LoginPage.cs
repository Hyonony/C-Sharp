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


namespace Winform_2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void ID_text_TextChanged(object sender, EventArgs e) //ID_text
        {
           
        }

        private void PW_text_TextChanged(object sender, EventArgs e) //PW_text
        {

        }

        private void Login_Button(object sender, EventArgs e) //LoginButton
        {
            string connString = "server=localhost;user=root;password=root;database=DB_user;";

            // MySQL 연결 객체 생성
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                // MySQL 연결
                conn.Open();

                // 로그인 쿼리문 생성
                string query = "SELECT * FROM users WHERE id = @id AND pw = @pw";

                // 로그인 쿼리문 실행 객체 생성
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // 로그인 폼에서 입력받은 ID와 PW 값 가져오기
                string id = ID_text.Text;
                string password = PW_text.Text;

                // 로그인 쿼리문에 파라미터 추가
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pw", password);

                // 로그인 쿼리문 실행
                MySqlDataReader reader = cmd.ExecuteReader();

                // 로그인 결과 확인
                if (reader.HasRows)
                {
                    MessageBox.Show("로그인 되었습니다.");
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다.");
                }

                // 데이터베이스 리소스 해제
                reader.Close();
            }
            catch (Exception ex)
            {
                // 오류 발생 시 메시지 출력
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // MySQL 연결 종료
                conn.Close();
            }
        }

        private void regist_button_Click(object sender, EventArgs e) //regist_button
        {
            Application.Restart();
        }
    }
}
