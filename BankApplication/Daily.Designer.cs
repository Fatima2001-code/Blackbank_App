namespace BankApplication
{
    partial class Daily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily));
            date = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            text_AccID = new TextBox();
            Back = new Button();
            button1 = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            print = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = SystemColors.WindowText;
            date.Location = new Point(62, 193);
            date.Name = "date";
            date.Size = new Size(58, 31);
            date.TabIndex = 61;
            date.Text = "Day";
            date.Click += date_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ActiveCaptionText;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1267, 356);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(54, 133);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 58;
            label3.Text = "Account ID";
            label3.Click += label3_Click;
            // 
            // text_AccID
            // 
            text_AccID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_AccID.Location = new Point(194, 133);
            text_AccID.Margin = new Padding(3, 4, 3, 4);
            text_AccID.Name = "text_AccID";
            text_AccID.Size = new Size(247, 34);
            text_AccID.TabIndex = 57;
            text_AccID.TextChanged += text_AccID_TextChanged;
            // 
            // Back
            // 
            Back.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = SystemColors.MenuHighlight;
            Back.Location = new Point(54, 336);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(162, 47);
            Back.TabIndex = 56;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(62, 27);
            button1.Name = "button1";
            button1.Size = new Size(379, 61);
            button1.TabIndex = 55;
            button1.Text = "Customer Balance Daily";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(279, 336);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(162, 48);
            button2.TabIndex = 62;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // print
            // 
            print.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            print.ForeColor = SystemColors.MenuHighlight;
            print.Location = new Point(279, 261);
            print.Margin = new Padding(3, 4, 3, 4);
            print.Name = "print";
            print.Size = new Size(162, 48);
            print.TabIndex = 63;
            print.Text = "Print";
            print.UseVisualStyleBackColor = true;
            print.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(194, 193);
            numericUpDown1.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(247, 34);
            numericUpDown1.TabIndex = 64;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Daily
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1743, 421);
            Controls.Add(numericUpDown1);
            Controls.Add(print);
            Controls.Add(button2);
            Controls.Add(date);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(text_AccID);
            Controls.Add(Back);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Daily";
            Text = "Daily";
            Load += Daily_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label date;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox text_AccID;
        private Button Back;
        private Button button1;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Button print;
        private NumericUpDown numericUpDown1;
    }
}