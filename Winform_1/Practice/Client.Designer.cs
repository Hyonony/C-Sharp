namespace Practice
{
    partial class Client
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
            this.Send_button = new System.Windows.Forms.Button();
            this.recieveText = new System.Windows.Forms.RichTextBox();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Port_number = new System.Windows.Forms.Label();
            this.IP_Label = new System.Windows.Forms.Label();
            this.Send_text = new System.Windows.Forms.TextBox();
            this.Port_text = new System.Windows.Forms.TextBox();
            this.IP_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(611, 522);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(146, 43);
            this.Send_button.TabIndex = 15;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.send_Button);
            // 
            // recieveText
            // 
            this.recieveText.Location = new System.Drawing.Point(35, 143);
            this.recieveText.Name = "recieveText";
            this.recieveText.Size = new System.Drawing.Size(722, 367);
            this.recieveText.TabIndex = 14;
            this.recieveText.Text = "";
            this.recieveText.TextChanged += new System.EventHandler(this.Recieve_text);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(507, 44);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(244, 64);
            this.Connect_button.TabIndex = 13;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.connect_Button);
            // 
            // Port_number
            // 
            this.Port_number.AutoSize = true;
            this.Port_number.Location = new System.Drawing.Point(268, 49);
            this.Port_number.Name = "Port_number";
            this.Port_number.Size = new System.Drawing.Size(41, 18);
            this.Port_number.TabIndex = 12;
            this.Port_number.Text = "Port";
            // 
            // IP_Label
            // 
            this.IP_Label.AutoSize = true;
            this.IP_Label.Location = new System.Drawing.Point(47, 49);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(96, 18);
            this.IP_Label.TabIndex = 11;
            this.IP_Label.Text = "IP Address";
            // 
            // Send_text
            // 
            this.Send_text.Font = new System.Drawing.Font("굴림", 12F);
            this.Send_text.Location = new System.Drawing.Point(42, 522);
            this.Send_text.Name = "Send_text";
            this.Send_text.Size = new System.Drawing.Size(563, 35);
            this.Send_text.TabIndex = 10;
            this.Send_text.TextChanged += new System.EventHandler(this.senD_text);
            // 
            // Port_text
            // 
            this.Port_text.Location = new System.Drawing.Point(263, 80);
            this.Port_text.Name = "Port_text";
            this.Port_text.Size = new System.Drawing.Size(202, 28);
            this.Port_text.TabIndex = 9;
            this.Port_text.TextChanged += new System.EventHandler(this.porT_text);
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(42, 80);
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(202, 28);
            this.IP_text.TabIndex = 8;
            this.IP_text.TextChanged += new System.EventHandler(this.iP_text);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.recieveText);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Port_number);
            this.Controls.Add(this.IP_Label);
            this.Controls.Add(this.Send_text);
            this.Controls.Add(this.Port_text);
            this.Controls.Add(this.IP_text);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.RichTextBox recieveText;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Label Port_number;
        private System.Windows.Forms.Label IP_Label;
        private System.Windows.Forms.TextBox Send_text;
        private System.Windows.Forms.TextBox Port_text;
        private System.Windows.Forms.TextBox IP_text;
    }
}