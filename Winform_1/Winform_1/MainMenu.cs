using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class MainMenu : Form
    {
        private bool NameBoxClicked = false;
        private bool AgeBoxClicked = false;
        private bool HeightBoxClicked = false;

        public string strName;
        public string strAge;
        public string strWeight;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_button(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FoodList(object sender, EventArgs e)
        {

        }

        private void FoodText(object sender, EventArgs e)
        {

        }

        private void InsertTextButton(object sender, EventArgs e)
        {
            if (TextFood.Text != "") //공백이 아닐경우
            {
                FoodBox.Items.Add(TextFood.Text);
                TextFood.Text = "";
            }
            else
            {
                MessageBox.Show("값을 입력해주세요.", "! ! !");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (FoodBox.SelectedIndex != -1)
            {
                FoodBox.Items.RemoveAt(FoodBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("값을 선택해주세요.", "! ! !");
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            // 리스트 박스 Label
        }

        private void listView1_(object sender, EventArgs e)
        {

        }

        private void Insert_name(object sender, EventArgs e)
        {
            if (!NameBoxClicked)
            {
                NameBox.Clear();
                NameBoxClicked = true;
            }
        }

        private void Insert_age(object sender, EventArgs e)
        {
            if (!AgeBoxClicked)
            {
                AgeBox.Clear();
                AgeBoxClicked = true;
            }
        }

        private void Insert_Height(object sender, EventArgs e)
        {
            if (!HeightBoxClicked)
            {
                HeightBox.Clear();
                HeightBoxClicked = true;
            }
        }
        

        private void RegistButton_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;

            strName = this.NameBox.Text;
            strAge = this.AgeBox.Text;
            strWeight = this.HeightBox.Text;

            listView.Columns.Add("이름", 100, HorizontalAlignment.Left);
            listView.Columns.Add("나이", 100, HorizontalAlignment.Left);
            listView.Columns.Add("키", 100, HorizontalAlignment.Left);


            string[] row = {strName, strAge, strWeight };

            listView.Items.Add(new ListViewItem(row));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count > 0)
            {
                int index = this.listView.FocusedItem.Index;
                listView.Items.RemoveAt(index);
            }
        }

        private void Client_page(object sender, EventArgs e)
        {
            Client otherform = new Client();
            otherform.Show();
        }

        private void Server_page(object sender, EventArgs e)
        {
            Server otherform = new Server();
            otherform.Show();
        }

        private void Crawling_button_Click(object sender, EventArgs e)
        {
            Crawling crawling = new Crawling();
            crawling.Show();
        }
    }
}