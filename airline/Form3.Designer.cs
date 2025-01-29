namespace airline
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label2 = new Label();
            lblWeight = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(112, 145);
            label2.Name = "label2";
            label2.Size = new Size(353, 46);
            label2.TabIndex = 8;
            label2.Text = "Your current weight is:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 20F);
            lblWeight.Location = new Point(471, 145);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(109, 46);
            lblWeight.TabIndex = 9;
            lblWeight.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 36);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(155, 353);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 12;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(384, 353);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 13;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 444);
            label5.Name = "label5";
            label5.Size = new Size(279, 35);
            label5.TabIndex = 19;
            label5.Text = "*Extra Fees May Apply";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(648, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 425);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 521);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(lblWeight);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblWeight;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label5;
        private PictureBox pictureBox1;
    }
}