namespace WinFormsApplication1
{
    partial class FRM_GRIDVIEW
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
            BTN_NewForm = new Button();
            dataGridView1 = new DataGridView();
            GetData = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            linkLabel8 = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // BTN_NewForm
            // 
            BTN_NewForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTN_NewForm.ForeColor = Color.Teal;
            BTN_NewForm.Location = new Point(595, 144);
            BTN_NewForm.Name = "BTN_NewForm";
            BTN_NewForm.Size = new Size(155, 34);
            BTN_NewForm.TabIndex = 1;
            BTN_NewForm.Text = "Open New Form";
            BTN_NewForm.UseVisualStyleBackColor = true;
            BTN_NewForm.Click += BTN_NewForm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 212);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // GetData
            // 
            GetData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            GetData.ForeColor = Color.Teal;
            GetData.Location = new Point(378, 417);
            GetData.Name = "GetData";
            GetData.Size = new Size(135, 37);
            GetData.TabIndex = 3;
            GetData.Text = "Get Data";
            GetData.UseVisualStyleBackColor = true;
            GetData.Click += GetData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(142, 151);
            label1.Name = "label1";
            label1.Size = new Size(338, 30);
            label1.TabIndex = 4;
            label1.Text = "Business Trading Listening Results";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(288, 78);
            label2.Name = "label2";
            label2.Size = new Size(241, 37);
            label2.TabIndex = 5;
            label2.Text = "Welcome Investor ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download_77;
            pictureBox1.Location = new Point(605, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(180, 550);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 17);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LinkedIn";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.linkedin;
            pictureBox2.Location = new Point(201, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.github;
            pictureBox3.Location = new Point(257, 518);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.email;
            pictureBox4.Location = new Point(312, 518);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.x;
            pictureBox5.Location = new Point(370, 518);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.download_EFG;
            pictureBox6.Location = new Point(426, 518);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(245, 550);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(51, 17);
            linkLabel2.TabIndex = 17;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "GitHub";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(302, 552);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(43, 17);
            linkLabel3.TabIndex = 18;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Gmail";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(370, 550);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(16, 17);
            linkLabel4.TabIndex = 19;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "X";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel5.LinkColor = Color.Black;
            linkLabel5.Location = new Point(415, 552);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(56, 17);
            linkLabel5.TabIndex = 20;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Website";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.youtube;
            pictureBox7.Location = new Point(493, 518);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(28, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.facebook;
            pictureBox8.Location = new Point(556, 518);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.insta;
            pictureBox9.Location = new Point(629, 518);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(40, 29);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel6.LinkColor = Color.Black;
            linkLabel6.Location = new Point(477, 554);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(58, 17);
            linkLabel6.TabIndex = 24;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Youtube";
            // 
            // linkLabel7
            // 
            linkLabel7.AutoSize = true;
            linkLabel7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel7.LinkColor = Color.Black;
            linkLabel7.Location = new Point(541, 552);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(63, 17);
            linkLabel7.TabIndex = 25;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "Facebook";
            // 
            // linkLabel8
            // 
            linkLabel8.AutoSize = true;
            linkLabel8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel8.LinkColor = Color.Black;
            linkLabel8.Location = new Point(619, 552);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(67, 17);
            linkLabel8.TabIndex = 26;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "Instagram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 599);
            label3.Name = "label3";
            label3.Size = new Size(521, 25);
            label3.TabIndex = 27;
            label3.Text = "Made With Love By Ali Wazeer @ 2024 All Rights Reserved ";
            // 
            // FRM_GRIDVIEW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(897, 624);
            Controls.Add(label3);
            Controls.Add(linkLabel8);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel6);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GetData);
            Controls.Add(dataGridView1);
            Controls.Add(BTN_NewForm);
            Name = "FRM_GRIDVIEW";
            Text = "FRM_GRIDVIEW";
            Load += FRM_GRIDVIEW_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTN_NewForm;
        public DataGridView dataGridView1;
        private Button GetData;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private LinkLabel linkLabel8;
        private Label label3;
    }
}
