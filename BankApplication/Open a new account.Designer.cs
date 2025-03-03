namespace BankApplication
{
    partial class Open_a_new_account
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open_a_new_account));
            label1 = new Label();
            text_name = new TextBox();
            label2 = new Label();
            text_Phone = new TextBox();
            label3 = new Label();
            text_type = new TextBox();
            label4 = new Label();
            text_Email = new TextBox();
            label5 = new Label();
            text_Address = new TextBox();
            label6 = new Label();
            text_Balance = new TextBox();
            button_login = new Button();
            Back = new Button();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // text_name
            // 
            text_name.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_name.Location = new Point(109, 44);
            text_name.Margin = new Padding(3, 4, 3, 4);
            text_name.Name = "text_name";
            text_name.Size = new Size(175, 30);
            text_name.TabIndex = 3;
            text_name.TextChanged += text_username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(16, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 6;
            label2.Text = "Phone";
            // 
            // text_Phone
            // 
            text_Phone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_Phone.Location = new Point(109, 99);
            text_Phone.Margin = new Padding(3, 4, 3, 4);
            text_Phone.Name = "text_Phone";
            text_Phone.Size = new Size(175, 30);
            text_Phone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(365, 51);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 8;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // text_type
            // 
            text_type.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_type.Location = new Point(474, 99);
            text_type.Margin = new Padding(3, 4, 3, 4);
            text_type.Name = "text_type";
            text_type.Size = new Size(175, 30);
            text_type.TabIndex = 7;
            text_type.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(19, 151);
            label4.Name = "label4";
            label4.Size = new Size(87, 31);
            label4.TabIndex = 10;
            label4.Text = "E-mail";
            // 
            // text_Email
            // 
            text_Email.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_Email.Location = new Point(109, 147);
            text_Email.Margin = new Padding(3, 4, 3, 4);
            text_Email.Name = "text_Email";
            text_Email.Size = new Size(175, 30);
            text_Email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(310, 103);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 12;
            label5.Text = "Account Type";
            // 
            // text_Address
            // 
            text_Address.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_Address.Location = new Point(474, 51);
            text_Address.Margin = new Padding(3, 4, 3, 4);
            text_Address.Name = "text_Address";
            text_Address.Size = new Size(175, 30);
            text_Address.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(365, 151);
            label6.Name = "label6";
            label6.Size = new Size(102, 31);
            label6.TabIndex = 14;
            label6.Text = "Balance";
            label6.Click += label6_Click;
            // 
            // text_Balance
            // 
            text_Balance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_Balance.Location = new Point(473, 147);
            text_Balance.Margin = new Padding(3, 4, 3, 4);
            text_Balance.Name = "text_Balance";
            text_Balance.Size = new Size(175, 30);
            text_Balance.TabIndex = 13;
            text_Balance.TextChanged += textBox5_TextChanged;
            // 
            // button_login
            // 
            button_login.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(438, 309);
            button_login.Margin = new Padding(3, 4, 3, 4);
            button_login.Name = "button_login";
            button_login.Size = new Size(211, 68);
            button_login.TabIndex = 15;
            button_login.Text = "Save";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = SystemColors.MenuHighlight;
            Back.Location = new Point(19, 309);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(210, 68);
            Back.TabIndex = 29;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(61, 226);
            label8.Name = "label8";
            label8.Size = new Size(168, 31);
            label8.TabIndex = 33;
            label8.Text = "Deposite Date";
            label8.Click += label8_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(239, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 34);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.Value = new DateTime(2023, 6, 24, 17, 52, 52, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Open_a_new_account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(667, 421);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(Back);
            Controls.Add(button_login);
            Controls.Add(label6);
            Controls.Add(text_Balance);
            Controls.Add(label5);
            Controls.Add(text_Address);
            Controls.Add(label4);
            Controls.Add(text_Email);
            Controls.Add(label3);
            Controls.Add(text_type);
            Controls.Add(label2);
            Controls.Add(text_Phone);
            Controls.Add(label1);
            Controls.Add(text_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Open_a_new_account";
            Text = "Open_a_new_account";
            Load += Open_a_new_account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_name;
        private Label label2;
        private TextBox text_Phone;
        private Label label3;
        private TextBox text_type;
        private Label label4;
        private TextBox text_Email;
        private Label label5;
        private TextBox text_Address;
        private Label label6;
        private TextBox text_Balance;
        private Button button_login;
        private Button Back;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker dateTimePicker1;
    }
}