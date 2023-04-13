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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void Regist_Load(object sender, EventArgs e)
        {
            Job_box.SelectedIndex = 0;
        }

        public void Name_text_TextChanged(object sender, EventArgs e) //Name_text
        {

        }

        public void ID_text_TextChanged(object sender, EventArgs e) //ID_text
        {

        }

        public void PW_text_TextChanged(object sender, EventArgs e) //PW_text
        {

        }

        private void PWC_text_TextChanged(object sender, EventArgs e)//PWC_text
        {

        }

        private void Address_text_TextChanged(object sender, EventArgs e)//Address_text
        {

        }

        private void add_num_text_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//add_num_text
        {

        }

        private void Job_box_SelectedIndexChanged(object sender, EventArgs e) //Job_box
        {

        }

        private void phone_text_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//phone_text
        {

        }

        private void zen_check_SelectedIndexChanged(object sender, EventArgs e) //zen_check 성별 체크
        {

        }

        private void regist_button_Click(object sender, EventArgs e) //regist_button 회원가입 버튼
        {
            if (ID_text.Text == string.Empty)
            {
                MessageBox.Show("아이디 중복검사를 하세요!!");

                return;
            }
            if (Name_text.Text.Length < 2 || Name_text.TextLength > 5)
            {
                MessageBox.Show("이름은 2~5자 이내");
                Name_text.Focus();

                return;

            }
            for (int i = 0; i < Name_text.TextLength; i++)
            {
                char c = Name_text.Text[i];
                if (c < '가' || c > '힣')
                {
                    MessageBox.Show("이름은 반드시 한글로");
                    Name_text.Focus();

                    return;
                }

            }
            if (PW_text.TextLength < 4 || PW_text.TextLength > 12)
            {
                MessageBox.Show("비밀번호는 4~12자 이내");
                PW_text.Focus();

                return;

            }
            if (PWC_text.TextLength < 4 || PWC_text.TextLength > 12)
            {
                MessageBox.Show("비밀번호확인은 4~12자 이내");
                PWC_text.Focus();

                return;
            }
            if (PW_text.Text != PWC_text.Text)
            {
                MessageBox.Show("비밀번호값을 다시 확인 하세요");
                PW_text.Focus();

                return;
            }
            if (Job_box.SelectedIndex == 0)
            {
                MessageBox.Show("직업을 선택하세요");
                Job_box.Focus();

                return;
            }
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=DB_user;Uid=root;Pwd=root;");
                connection.Open();

                string checKquery = "SELECT * FROM users WHERE id = @id";

                // 로그인 쿼리문 실행 객체 생성
                MySqlCommand cmd = new MySqlCommand(checKquery, connection);

                // 로그인 폼에서 입력받은 ID와 PW 값 가져오기
                string id = ID_text.Text;

                // 로그인 쿼리문에 파라미터 추가
                cmd.Parameters.AddWithValue("@id", id);

                // 로그인 쿼리문 실행
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("겹치는 아이디입니다. 아이디 중복 검사를 해보세요.","회원가입 실패");
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    string insertQuery = "INSERT INTO users (name, id, pw, pwc, address, zip_code, job, phone_number, sex) VALUES (@name, @id, @pw, @pwc, @address, @zip_code, @job, @phone_number, @sex) ";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", Name_text.Text);
                        command.Parameters.AddWithValue("@id", ID_text.Text);
                        command.Parameters.AddWithValue("@pw", PW_text.Text);
                        command.Parameters.AddWithValue("@pwc", PWC_text.Text);
                        command.Parameters.AddWithValue("@address", Address_text.Text);
                        command.Parameters.AddWithValue("@zip_code", add_num_text.Text);
                        command.Parameters.AddWithValue("@job", Job_box.Text);
                        command.Parameters.AddWithValue("@phone_number", phone_text.Text);
                        command.Parameters.AddWithValue("@sex", zen_check.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("회원가입 성공!!");
                    connection.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void login_form_Click(object sender, EventArgs e) //login_form 로그인 창으로 이동
        {
            LoginPage loginpage = new LoginPage();

            // 현재 폼 숨기기
            this.Hide();
            DialogResult result = loginpage.ShowDialog();
            // Form2 보여주기

            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void ID_check_Click(object sender, EventArgs e) //ID_check 중복검사
        {
            duplication Dupli = new duplication();


            DialogResult result = Dupli.ShowDialog();
            
        }

        private void Open_PW_CheckedChanged(object sender, EventArgs e)
        { 
            if (Open_PW.Checked == true)
            {
                PW_text.PasswordChar = default(char);
            }
            else
            {
                PW_text.PasswordChar = '*';
            }
        }

        private void Open_PWC_CheckedChanged(object sender, EventArgs e)
        {
            if (Open_PWC.Checked == true)
            {
                PWC_text.PasswordChar = default(char);
            }
            else
            {
                PWC_text.PasswordChar = '*';
            }
        }
    }

}
