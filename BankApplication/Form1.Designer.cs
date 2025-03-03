namespace BankApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button_login = new Button();
            text_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            text_password = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(174, 323);
            button_login.Margin = new Padding(3, 4, 3, 4);
            button_login.Name = "button_login";
            button_login.Size = new Size(320, 60);
            button_login.TabIndex = 0;
            button_login.Text = "Log in";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // text_username
            // 
            text_username.BackColor = SystemColors.Control;
            text_username.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_username.Location = new Point(267, 137);
            text_username.Margin = new Padding(3, 4, 3, 4);
            text_username.Name = "text_username";
            text_username.Size = new Size(303, 42);
            text_username.TabIndex = 11;
            text_username.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(79, 143);
            label1.Name = "label1";
            label1.Size = new Size(170, 39);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(79, 213);
            label2.Name = "label2";
            label2.Size = new Size(147, 39);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // text_password
            // 
            text_password.BackColor = SystemColors.Control;
            text_password.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(267, 213);
            text_password.Margin = new Padding(3, 4, 3, 4);
            text_password.Name = "text_password";
            text_password.Size = new Size(303, 42);
            text_password.TabIndex = 11;
            text_password.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Perpetua Titling MT", 38F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(174, 25);
            label3.Name = "label3";
            label3.Size = new Size(351, 75);
            label3.TabIndex = 5;
            label3.Text = "Welcome";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(667, 421);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(text_password);
            Controls.Add(label1);
            Controls.Add(text_username);
            Controls.Add(button_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "LogIn";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button_login;
        private TextBox text_username;
        private Label label1;
        private Label label2;
        private TextBox text_password;
        private Label label3;
    }
}