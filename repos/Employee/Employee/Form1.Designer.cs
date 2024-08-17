namespace Employee
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
            label1 = new Label();
            textarea = new Panel();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            IDbtn = new TextBox();
            Quantitybtn = new TextBox();
            Pricebtn = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Submitbtn = new Button();
            cboState = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            textarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 0;
            label1.Text = "Employee Investor";
            // 
            // textarea
            // 
            textarea.BackColor = Color.Teal;
            textarea.Controls.Add(label12);
            textarea.Controls.Add(pictureBox1);
            textarea.Controls.Add(label9);
            textarea.Controls.Add(label8);
            textarea.Controls.Add(label7);
            textarea.Controls.Add(label6);
            textarea.Dock = DockStyle.Left;
            textarea.Location = new Point(0, 0);
            textarea.Name = "textarea";
            textarea.Size = new Size(183, 328);
            textarea.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(12, 286);
            label12.Name = "label12";
            label12.Size = new Size(154, 21);
            label12.TabIndex = 5;
            label12.Text = "Trainee / Ali Wazeer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download_EFG;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 238);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 3;
            label9.Text = "Eng.M/Bayumi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(5, 209);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 2;
            label8.Text = "UnderSuperVision";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 179);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 1;
            label7.Text = "Company";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(22, 147);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 0;
            label6.Text = "EFG Holding";
            // 
            // IDbtn
            // 
            IDbtn.Location = new Point(279, 92);
            IDbtn.Name = "IDbtn";
            IDbtn.Size = new Size(100, 23);
            IDbtn.TabIndex = 2;
            // 
            // Quantitybtn
            // 
            Quantitybtn.Location = new Point(279, 126);
            Quantitybtn.Name = "Quantitybtn";
            Quantitybtn.Size = new Size(100, 23);
            Quantitybtn.TabIndex = 3;
            // 
            // Pricebtn
            // 
            Pricebtn.Location = new Point(279, 163);
            Pricebtn.Name = "Pricebtn";
            Pricebtn.Size = new Size(100, 23);
            Pricebtn.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(189, 90);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 6;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(189, 123);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(189, 161);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 8;
            label4.Text = "Price";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(189, 192);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 9;
            label5.Text = "Directions";
            label5.Click += label5_Click;
            // 
            // Submitbtn
            // 
            Submitbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submitbtn.ForeColor = Color.Teal;
            Submitbtn.Location = new Point(478, 238);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(111, 28);
            Submitbtn.TabIndex = 10;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // cboState
            // 
            cboState.DropDownStyle = ComboBoxStyle.DropDownList;
            cboState.FormattingEnabled = true;
            cboState.Items.AddRange(new object[] { "Sell", "Buy" });
            cboState.Location = new Point(279, 194);
            cboState.Name = "cboState";
            cboState.Size = new Size(100, 23);
            cboState.TabIndex = 11;
            cboState.SelectedIndexChanged += cboState_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(239, 238);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 12;
            label10.Text = "Selected";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(334, 240);
            label11.Name = "label11";
            label11.Size = new Size(14, 17);
            label11.TabIndex = 13;
            label11.Text = "?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(478, 286);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 14;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 328);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboState);
            Controls.Add(Submitbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Pricebtn);
            Controls.Add(Quantitybtn);
            Controls.Add(IDbtn);
            Controls.Add(textarea);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Employee";
            Load += Form1_Load;
            textarea.ResumeLayout(false);
            textarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel textarea;
        private TextBox IDbtn;
        private TextBox Quantitybtn;
        private TextBox Pricebtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Submitbtn;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private ComboBox cboState;
        private Label label10;
        private Label label11;
        private Button button1;
        private Label label12;
    }
}
