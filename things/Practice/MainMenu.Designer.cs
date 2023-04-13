namespace Practice
{
    partial class MainMenu
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.FoodBox = new System.Windows.Forms.ListBox();
            this.TextFood = new System.Windows.Forms.TextBox();
            this.InsertFood = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClientPage = new System.Windows.Forms.Button();
            this.ListBox_label = new System.Windows.Forms.Label();
            this.ListView_label = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.RegistButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ServerPage = new System.Windows.Forms.Button();
            this.Crawling_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(601, 480);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(187, 108);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit Button";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_button);
            // 
            // FoodBox
            // 
            this.FoodBox.FormattingEnabled = true;
            this.FoodBox.ItemHeight = 18;
            this.FoodBox.Items.AddRange(new object[] {
            "오므라이스",
            "짜장면",
            "초밥",
            "파스타"});
            this.FoodBox.Location = new System.Drawing.Point(31, 64);
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(319, 220);
            this.FoodBox.TabIndex = 1;
            this.FoodBox.SelectedIndexChanged += new System.EventHandler(this.FoodList);
            // 
            // TextFood
            // 
            this.TextFood.Location = new System.Drawing.Point(31, 296);
            this.TextFood.Name = "TextFood";
            this.TextFood.Size = new System.Drawing.Size(319, 28);
            this.TextFood.TabIndex = 2;
            this.TextFood.TextChanged += new System.EventHandler(this.FoodText);
            // 
            // InsertFood
            // 
            this.InsertFood.Location = new System.Drawing.Point(31, 345);
            this.InsertFood.Name = "InsertFood";
            this.InsertFood.Size = new System.Drawing.Size(132, 72);
            this.InsertFood.TabIndex = 3;
            this.InsertFood.Text = "Insert";
            this.InsertFood.UseVisualStyleBackColor = true;
            this.InsertFood.Click += new System.EventHandler(this.InsertTextButton);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(218, 345);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(132, 72);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClientPage
            // 
            this.ClientPage.Location = new System.Drawing.Point(218, 491);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Size = new System.Drawing.Size(132, 86);
            this.ClientPage.TabIndex = 5;
            this.ClientPage.Text = "Client(TCP)";
            this.ClientPage.UseVisualStyleBackColor = true;
            this.ClientPage.Click += new System.EventHandler(this.Client_page);
            // 
            // ListBox_label
            // 
            this.ListBox_label.AutoSize = true;
            this.ListBox_label.Location = new System.Drawing.Point(28, 26);
            this.ListBox_label.Name = "ListBox_label";
            this.ListBox_label.Size = new System.Drawing.Size(67, 18);
            this.ListBox_label.TabIndex = 6;
            this.ListBox_label.Text = "ListBox";
            this.ListBox_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListView_label
            // 
            this.ListView_label.AutoSize = true;
            this.ListView_label.Location = new System.Drawing.Point(409, 26);
            this.ListView_label.Name = "ListView_label";
            this.ListView_label.Size = new System.Drawing.Size(73, 18);
            this.ListView_label.TabIndex = 7;
            this.ListView_label.Text = "ListView";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(404, 64);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(340, 242);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("굴림", 8F);
            this.NameBox.Location = new System.Drawing.Point(404, 330);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(172, 26);
            this.NameBox.TabIndex = 10;
            this.NameBox.Text = "이름(입력시 자동지움)";
            this.NameBox.TextChanged += new System.EventHandler(this.Insert_name);
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("굴림", 8F);
            this.AgeBox.Location = new System.Drawing.Point(404, 364);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(172, 26);
            this.AgeBox.TabIndex = 10;
            this.AgeBox.Text = "나이(입력시 자동지움)";
            this.AgeBox.TextChanged += new System.EventHandler(this.Insert_age);
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("굴림", 8F);
            this.HeightBox.Location = new System.Drawing.Point(404, 398);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(172, 26);
            this.HeightBox.TabIndex = 10;
            this.HeightBox.Text = "키(입력시 자동지움)";
            this.HeightBox.TextChanged += new System.EventHandler(this.Insert_Height);
            // 
            // RegistButton
            // 
            this.RegistButton.Location = new System.Drawing.Point(582, 330);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(162, 42);
            this.RegistButton.TabIndex = 11;
            this.RegistButton.Text = "ADD";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(582, 382);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(162, 42);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ServerPage
            // 
            this.ServerPage.Location = new System.Drawing.Point(412, 491);
            this.ServerPage.Name = "ServerPage";
            this.ServerPage.Size = new System.Drawing.Size(132, 86);
            this.ServerPage.TabIndex = 13;
            this.ServerPage.Text = "Server(TCP)";
            this.ServerPage.UseVisualStyleBackColor = true;
            this.ServerPage.Click += new System.EventHandler(this.Server_page);
            // 
            // Crawling_button
            // 
            this.Crawling_button.Location = new System.Drawing.Point(31, 491);
            this.Crawling_button.Name = "Crawling_button";
            this.Crawling_button.Size = new System.Drawing.Size(132, 86);
            this.Crawling_button.TabIndex = 14;
            this.Crawling_button.Text = "Crawling";
            this.Crawling_button.UseVisualStyleBackColor = true;
            this.Crawling_button.Click += new System.EventHandler(this.Crawling_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Crawling_button);
            this.Controls.Add(this.ServerPage);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.ListView_label);
            this.Controls.Add(this.ListBox_label);
            this.Controls.Add(this.ClientPage);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.InsertFood);
            this.Controls.Add(this.TextFood);
            this.Controls.Add(this.FoodBox);
            this.Controls.Add(this.ExitButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox FoodBox;
        private System.Windows.Forms.TextBox TextFood;
        private System.Windows.Forms.Button InsertFood;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClientPage;
        private System.Windows.Forms.Label ListBox_label;
        private System.Windows.Forms.Label ListView_label;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ServerPage;
        private System.Windows.Forms.Button Crawling_button;
    }
}

