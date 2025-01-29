namespace airline
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <p name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtLastName = new TextBox();
            txtPNR = new TextBox();
            pnrLabel = new Label();
            lastNameLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Segoe UI", 16F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(355, 307);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 43);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtPNR
            // 
            txtPNR.BackColor = Color.White;
            txtPNR.Font = new Font("Segoe UI", 16F);
            txtPNR.ForeColor = Color.Black;
            txtPNR.Location = new Point(355, 258);
            txtPNR.Name = "txtPNR";
            txtPNR.Size = new Size(221, 43);
            txtPNR.TabIndex = 3;
            txtPNR.TextChanged += textBox2_TextChanged;
            // 
            // pnrLabel
            // 
            pnrLabel.AutoSize = true;
            pnrLabel.BackColor = Color.Transparent;
            pnrLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnrLabel.Location = new Point(222, 261);
            pnrLabel.Name = "pnrLabel";
            pnrLabel.Size = new Size(127, 38);
            pnrLabel.TabIndex = 4;
            pnrLabel.Text = "PNR NO:";
            pnrLabel.Click += pnrLabel_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(83, 310);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(266, 38);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Passenger Surname:";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 111);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Underline);
            label1.Location = new Point(146, 188);
            label1.Name = "label1";
            label1.Size = new Size(323, 35);
            label1.TabIndex = 0;
            label1.Text = "Check-in / Manage Booking";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(398, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 102);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(630, 162);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(372, 329);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1014, 532);
            Controls.Add(pictureBox4);
            Controls.Add(lastNameLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnrLabel);
            Controls.Add(txtPNR);
            Controls.Add(txtLastName);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sign in";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox txtLastName;
        private TextBox txtPNR;
        private Label pnrLabel;
        private Label lastNameLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
