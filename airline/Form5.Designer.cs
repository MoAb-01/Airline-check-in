namespace airline
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            lblDate = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(138, 67);
            label1.Name = "label1";
            label1.Size = new Size(415, 46);
            label1.TabIndex = 31;
            label1.Text = "Your current Flight Date is:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 456);
            label5.Name = "label5";
            label5.Size = new Size(279, 35);
            label5.TabIndex = 28;
            label5.Text = "*Extra Fees May Apply";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(526, 278);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 27;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(298, 278);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 26;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 20F);
            lblDate.Location = new Point(559, 67);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(109, 46);
            lblDate.TabIndex = 23;
            lblDate.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 142);
            label2.Name = "label2";
            label2.Size = new Size(275, 35);
            label2.TabIndex = 32;
            label2.Text = "*Extra Fees Will Apply";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(17, 203);
            label3.Name = "label3";
            label3.Size = new Size(266, 46);
            label3.TabIndex = 33;
            label3.Text = "Select your Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 44F);
            dateTimePicker1.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dateTimePicker1.Location = new Point(285, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 27);
            dateTimePicker1.TabIndex = 37;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 456);
            label4.Name = "label4";
            label4.Size = new Size(412, 35);
            label4.TabIndex = 38;
            label4.Text = "*You Can't Choose The Same Date";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(686, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(271, 204);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_12_15_18_44_27;
            ClientSize = new Size(960, 521);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDate);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form5";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label lblDate;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private PictureBox pictureBox3;
    }
}