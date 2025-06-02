namespace recruiter
{
    partial class PretendentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretendentsForm));
            pretendentsList = new FlowLayoutPanel();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            back = new Button();
            post = new ComboBox();
            searchBtn = new Button();
            label2 = new Label();
            label7 = new Label();
            education = new TextBox();
            label9 = new Label();
            qualification = new TextBox();
            label10 = new Label();
            otherInfo = new TextBox();
            label1 = new Label();
            experience = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pretendentsList
            // 
            pretendentsList.AutoScroll = true;
            pretendentsList.BackColor = Color.White;
            pretendentsList.Location = new Point(289, 16);
            pretendentsList.Margin = new Padding(3, 4, 3, 4);
            pretendentsList.Name = "pretendentsList";
            pretendentsList.Size = new Size(610, 468);
            pretendentsList.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(0, 147, 53);
            back.Font = new Font("Segoe UI", 9F);
            back.ForeColor = Color.White;
            back.Location = new Point(14, 452);
            back.Name = "back";
            back.Size = new Size(149, 32);
            back.TabIndex = 7;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // post
            // 
            post.BackColor = Color.White;
            post.FormattingEnabled = true;
            post.Location = new Point(145, 96);
            post.Margin = new Padding(3, 4, 3, 4);
            post.Name = "post";
            post.Size = new Size(138, 28);
            post.TabIndex = 9;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(0, 147, 53);
            searchBtn.Font = new Font("Segoe UI", 9F);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(15, 288);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(269, 32);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Поиск";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 13;
            label2.Text = "Должность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 177);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 22;
            label7.Text = "Образование";
            // 
            // education
            // 
            education.BackColor = Color.White;
            education.Location = new Point(145, 173);
            education.Margin = new Padding(3, 4, 3, 4);
            education.Name = "education";
            education.Size = new Size(138, 27);
            education.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 139);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 26;
            label9.Text = "Квалификация";
            // 
            // qualification
            // 
            qualification.BackColor = Color.White;
            qualification.Location = new Point(145, 135);
            qualification.Margin = new Padding(3, 4, 3, 4);
            qualification.Name = "qualification";
            qualification.Size = new Size(138, 27);
            qualification.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 255);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 28;
            label10.Text = "Др. информация";
            // 
            // otherInfo
            // 
            otherInfo.BackColor = Color.White;
            otherInfo.Location = new Point(145, 251);
            otherInfo.Margin = new Padding(3, 4, 3, 4);
            otherInfo.Name = "otherInfo";
            otherInfo.Size = new Size(138, 27);
            otherInfo.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 216);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 30;
            label1.Text = "Стаж";
            // 
            // experience
            // 
            experience.BackColor = Color.White;
            experience.Location = new Point(145, 212);
            experience.Margin = new Padding(3, 4, 3, 4);
            experience.Name = "experience";
            experience.Size = new Size(138, 27);
            experience.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 61);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PretendentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(913, 495);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(experience);
            Controls.Add(label10);
            Controls.Add(otherInfo);
            Controls.Add(label9);
            Controls.Add(qualification);
            Controls.Add(label7);
            Controls.Add(education);
            Controls.Add(label2);
            Controls.Add(searchBtn);
            Controls.Add(post);
            Controls.Add(back);
            Controls.Add(pretendentsList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PretendentsForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pretendentsList;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button back;
        private ComboBox post;
        private Button searchBtn;
        private Label label2;
        private Label label7;
        private TextBox education;
        private Label label9;
        private TextBox qualification;
        private Label label10;
        private TextBox otherInfo;
        private Label label1;
        private TextBox experience;
        private PictureBox pictureBox1;
    }
}