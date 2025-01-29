namespace airline
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            lblSeat = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(265, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 36);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(388, 461);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(160, 461);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 16;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 535);
            label5.Name = "label5";
            label5.Size = new Size(279, 35);
            label5.TabIndex = 18;
            label5.Text = "*Extra Fees May Apply";
            label5.Click += label5_Click_1;
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Font = new Font("Segoe UI", 20F);
            lblSeat.Location = new Point(370, 136);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(109, 46);
            lblSeat.TabIndex = 10;
            lblSeat.Text = "label1";
            lblSeat.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(66, 136);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 21;
            label1.Text = "Your current seat is:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(721, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 584);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-3, 28);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 23;
            label2.Text = "*Extra Fees May Apply";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 130);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 521);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(lblSeat);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblSeat;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}