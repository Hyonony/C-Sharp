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
    public partial class duplication : Form
    {

        public duplication()
        {
            InitializeComponent();
        }

        private void Use_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void out_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;user=root;password=root;database=DB_user;";

            // MySQL 연결 객체 생성
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                // MySQL 연결
                conn.Open();

                // 로그인 쿼리문 생성
                string query = "SELECT * FROM users WHERE id = @id";

                // 로그인 쿼리문 실행 객체 생성
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // 로그인 폼에서 입력받은 ID와 PW 값 가져오기
                string id = ID_check_text.Text;

                // 로그인 쿼리문에 파라미터 추가
                cmd.Parameters.AddWithValue("@id", id);

                // 로그인 쿼리문 실행
                MySqlDataReader reader = cmd.ExecuteReader();

                // 로그인 결과 확인
                if (reader.HasRows)
                {
                    MessageBox.Show("중복된 아이디입니다. 다른 아이디를 사용해주세요.");

                }
                else
                {
                    MessageBox.Show("사용 가능한 아이디입니다.");
                    Use_button.Enabled = true;
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

        private void ID_check_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
