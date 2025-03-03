namespace BankApplication
{
    partial class statement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statement));
            Back = new Button();
            Daily = new Button();
            Monthly = new Button();
            Yearly = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = SystemColors.MenuHighlight;
            Back.Location = new Point(212, 266);
            Back.Name = "Back";
            Back.Size = new Size(172, 40);
            Back.TabIndex = 17;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button1_Click;
            // 
            // Daily
            // 
            Daily.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Daily.ForeColor = SystemColors.MenuHighlight;
            Daily.Location = new Point(146, 34);
            Daily.Name = "Daily";
            Daily.Size = new Size(311, 66);
            Daily.TabIndex = 36;
            Daily.Text = "Daily";
            Daily.UseVisualStyleBackColor = true;
            Daily.Click += button1_Click_2;
            // 
            // Monthly
            // 
            Monthly.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Monthly.ForeColor = SystemColors.MenuHighlight;
            Monthly.Location = new Point(146, 106);
            Monthly.Name = "Monthly";
            Monthly.Size = new Size(311, 62);
            Monthly.TabIndex = 37;
            Monthly.Text = "Monthly";
            Monthly.UseVisualStyleBackColor = true;
            Monthly.Click += button2_Click_1;
            // 
            // Yearly
            // 
            Yearly.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Yearly.ForeColor = SystemColors.MenuHighlight;
            Yearly.Location = new Point(146, 174);
            Yearly.Name = "Yearly";
            Yearly.Size = new Size(311, 66);
            Yearly.TabIndex = 38;
            Yearly.Text = "Yearly";
            Yearly.UseVisualStyleBackColor = true;
            Yearly.Click += button3_Click;
            // 
            // statement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 316);
            Controls.Add(Yearly);
            Controls.Add(Monthly);
            Controls.Add(Daily);
            Controls.Add(Back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "statement";
            Text = "statement";
            Load += statement_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Back;
        private Button Daily;
        private Button Monthly;
        private Button Yearly;
    }
}