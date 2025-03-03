namespace BankApplication
{
    partial class Menuform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuform));
            button1 = new Button();
            Open_a_new_account = new Button();
            button3 = new Button();
            button4 = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(74, 25);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(433, 53);
            button1.TabIndex = 0;
            button1.Text = "Customer account statement";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Open_a_new_account
            // 
            Open_a_new_account.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Open_a_new_account.ForeColor = SystemColors.MenuHighlight;
            Open_a_new_account.Location = new Point(74, 78);
            Open_a_new_account.Margin = new Padding(3, 2, 3, 2);
            Open_a_new_account.Name = "Open_a_new_account";
            Open_a_new_account.Size = new Size(433, 48);
            Open_a_new_account.TabIndex = 1;
            Open_a_new_account.Text = "Open a new account";
            Open_a_new_account.UseVisualStyleBackColor = true;
            Open_a_new_account.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(74, 126);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(433, 55);
            button3.TabIndex = 2;
            button3.Text = "Closing a customer's account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(74, 181);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(433, 54);
            button4.TabIndex = 3;
            button4.Text = "Bank transfer procedure";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.ForeColor = SystemColors.MenuHighlight;
            Exit.Location = new Point(195, 260);
            Exit.Name = "Exit";
            Exit.Size = new Size(203, 46);
            Exit.TabIndex = 30;
            Exit.Text = "Exit";
            Exit.TextImageRelation = TextImageRelation.TextAboveImage;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 316);
            Controls.Add(Exit);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Open_a_new_account);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menuform";
            Text = "Menu";
            Load += Menuform_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Open_a_new_account;
        private Button button3;
        private Button button4;
        private Button Exit;
    }
}