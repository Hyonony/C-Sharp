namespace Practice
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_text = new System.Windows.Forms.TextBox();
            this.Port_text = new System.Windows.Forms.TextBox();
            this.Send_text = new System.Windows.Forms.TextBox();
            this.IP_Label = new System.Windows.Forms.Label();
            this.Port_number = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.recieve_Text = new System.Windows.Forms.RichTextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(35, 75);
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(202, 28);
            this.IP_text.TabIndex = 0;
            this.IP_text.TextChanged += new System.EventHandler(this.iP_text);
            // 
            // Port_text
            // 
            this.Port_text.Location = new System.Drawing.Point(256, 75);
            this.Port_text.Name = "Port_text";
            this.Port_text.Size = new System.Drawing.Size(202, 28);
            this.Port_text.TabIndex = 1;
            this.Port_text.TextChanged += new System.EventHandler(this.porT_text);
            // 
            // Send_text
            // 
            this.Send_text.Font = new System.Drawing.Font("굴림", 12F);
            this.Send_text.Location = new System.Drawing.Point(35, 524);
            this.Send_text.Name = "Send_text";
            this.Send_text.Size = new System.Drawing.Size(563, 35);
            this.Send_text.TabIndex = 2;
            this.Send_text.TextChanged += new System.EventHandler(this.senD_text);
            // 
            // IP_Label
            // 
            this.IP_Label.AutoSize = true;
            this.IP_Label.Location = new System.Drawing.Point(40, 44);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(96, 18);
            this.IP_Label.TabIndex = 3;
            this.IP_Label.Text = "IP Address";
            // 
            // Port_number
            // 
            this.Port_number.AutoSize = true;
            this.Port_number.Location = new System.Drawing.Point(261, 44);
            this.Port_number.Name = "Port_number";
            this.Port_number.Size = new System.Drawing.Size(41, 18);
            this.Port_number.TabIndex = 4;
            this.Port_number.Text = "Port";
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(500, 39);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(244, 64);
            this.Connect_button.TabIndex = 5;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.connect_Button);
            // 
            // recieve_Text
            // 
            this.recieve_Text.Location = new System.Drawing.Point(28, 128);
            this.recieve_Text.Name = "recieve_Text";
            this.recieve_Text.Size = new System.Drawing.Size(722, 377);
            this.recieve_Text.TabIndex = 6;
            this.recieve_Text.Text = "";
            this.recieve_Text.TextChanged += new System.EventHandler(this.Recieve_text);
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(604, 523);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(146, 39);
            this.Send_button.TabIndex = 7;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.send_Button);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.recieve_Text);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Port_number);
            this.Controls.Add(this.IP_Label);
            this.Controls.Add(this.Send_text);
            this.Controls.Add(this.Port_text);
            this.Controls.Add(this.IP_text);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_text;
        private System.Windows.Forms.TextBox Port_text;
        private System.Windows.Forms.TextBox Send_text;
        private System.Windows.Forms.Label IP_Label;
        private System.Windows.Forms.Label Port_number;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.RichTextBox recieve_Text;
        private System.Windows.Forms.Button Send_button;
    }
}