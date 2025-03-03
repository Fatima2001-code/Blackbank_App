namespace BankApplication
{
    partial class Close_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Close_account));
            label1 = new Label();
            text_name = new TextBox();
            button_login = new Button();
            label2 = new Label();
            text_ID = new TextBox();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(102, 67);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // text_name
            // 
            text_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_name.Location = new Point(255, 67);
            text_name.Name = "text_name";
            text_name.Size = new Size(248, 29);
            text_name.TabIndex = 5;
            text_name.TextChanged += text_username_TextChanged;
            // 
            // button_login
            // 
            button_login.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(330, 225);
            button_login.Name = "button_login";
            button_login.Size = new Size(172, 48);
            button_login.TabIndex = 16;
            button_login.Text = "Closing";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(65, 109);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 18;
            label2.Text = "Account ID";
            label2.Click += label2_Click;
            // 
            // text_ID
            // 
            text_ID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_ID.Location = new Point(255, 109);
            text_ID.Name = "text_ID";
            text_ID.Size = new Size(248, 29);
            text_ID.TabIndex = 17;
            text_ID.TextChanged += textBox1_TextChanged;
            // 
            // Back
            // 
            Back.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = SystemColors.MenuHighlight;
            Back.Location = new Point(65, 225);
            Back.Name = "Back";
            Back.Size = new Size(172, 48);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Close_account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 316);
            Controls.Add(Back);
            Controls.Add(label2);
            Controls.Add(text_ID);
            Controls.Add(button_login);
            Controls.Add(label1);
            Controls.Add(text_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Close_account";
            Text = "Close_account";
            Load += Close_account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_name;
        private Button button_login;
        private Label label2;
        private TextBox text_ID;
        private Button Back;
    }
}