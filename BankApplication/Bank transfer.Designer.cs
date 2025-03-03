namespace BankApplication
{ // Created by Fatima Hamdan
    partial class Bank_transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank_transfer));
            label2 = new Label();
            text_Receiver = new TextBox();
            label1 = new Label();
            text_Sender = new TextBox();
            label3 = new Label();
            text_ID = new TextBox();
            label4 = new Label();
            text_Amount = new TextBox();
            button_login = new Button();
            Back = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(69, 91);
            label2.Name = "label2";
            label2.Size = new Size(224, 34);
            label2.TabIndex = 22;
            label2.Text = "Receiver Account";
            label2.Click += label2_Click;
            // 
            // text_Receiver
            // 
            text_Receiver.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_Receiver.Location = new Point(310, 92);
            text_Receiver.Margin = new Padding(3, 4, 3, 4);
            text_Receiver.Name = "text_Receiver";
            text_Receiver.Size = new Size(283, 35);
            text_Receiver.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(69, 35);
            label1.Name = "label1";
            label1.Size = new Size(204, 34);
            label1.TabIndex = 20;
            label1.Text = "Sender Account";
            label1.Click += label1_Click;
            // 
            // text_Sender
            // 
            text_Sender.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_Sender.Location = new Point(310, 36);
            text_Sender.Margin = new Padding(3, 4, 3, 4);
            text_Sender.Name = "text_Sender";
            text_Sender.Size = new Size(283, 35);
            text_Sender.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(91, 202);
            label3.Name = "label3";
            label3.Size = new Size(172, 34);
            label3.TabIndex = 26;
            label3.Text = "Employee ID";
            // 
            // text_ID
            // 
            text_ID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_ID.Location = new Point(310, 202);
            text_ID.Margin = new Padding(3, 4, 3, 4);
            text_ID.Name = "text_ID";
            text_ID.Size = new Size(283, 35);
            text_ID.TabIndex = 25;
            text_ID.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(112, 147);
            label4.Name = "label4";
            label4.Size = new Size(112, 34);
            label4.TabIndex = 24;
            label4.Text = "Amount";
            // 
            // text_Amount
            // 
            text_Amount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_Amount.Location = new Point(310, 148);
            text_Amount.Margin = new Padding(3, 4, 3, 4);
            text_Amount.Name = "text_Amount";
            text_Amount.Size = new Size(283, 35);
            text_Amount.TabIndex = 23;
            text_Amount.TextChanged += textBox3_TextChanged;
            // 
            // button_login
            // 
            button_login.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(383, 333);
            button_login.Margin = new Padding(3, 4, 3, 4);
            button_login.Name = "button_login";
            button_login.Size = new Size(210, 61);
            button_login.TabIndex = 27;
            button_login.Text = "Save";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = SystemColors.MenuHighlight;
            Back.Location = new Point(69, 333);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(198, 61);
            Back.TabIndex = 28;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(130, 263);
            label5.Name = "label5";
            label5.Size = new Size(79, 34);
            label5.TabIndex = 30;
            label5.Text = "Date ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(234, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 34);
            dateTimePicker1.TabIndex = 36;
            dateTimePicker1.Value = new DateTime(2023, 6, 24, 17, 52, 52, 0);
            // 
            // Bank_transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(667, 421);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(Back);
            Controls.Add(button_login);
            Controls.Add(label3);
            Controls.Add(text_ID);
            Controls.Add(label4);
            Controls.Add(text_Amount);
            Controls.Add(label2);
            Controls.Add(text_Receiver);
            Controls.Add(label1);
            Controls.Add(text_Sender);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bank_transfer";
            Text = "Bank_transfer";
            Load += Bank_transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox text_Receiver;
        private Label label1;
        private TextBox text_Sender;
        private Label label3;
        private TextBox text_ID;
        private Label label4;
        private TextBox text_Amount;
        private Button button_login;
        private Button Back;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
// Created by Fatima Hamdan
