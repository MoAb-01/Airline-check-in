namespace airline
{
    partial class Form6
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
            label2 = new Label();
            lblCancel = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.Location = new Point(156, 9);
            label2.Name = "label2";
            label2.Size = new Size(320, 57);
            label2.TabIndex = 33;
            label2.Text = "Canceling your";
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.BackColor = Color.Transparent;
            lblCancel.Font = new Font("Segoe UI", 25F);
            lblCancel.Location = new Point(472, 9);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(136, 57);
            lblCancel.TabIndex = 34;
            lblCancel.Text = "label1";
            lblCancel.Click += lblDate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(614, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 57);
            label1.TabIndex = 35;
            label1.Text = "Flight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(288, 81);
            label3.Name = "label3";
            label3.Size = new Size(343, 37);
            label3.TabIndex = 36;
            label3.Text = "Read The below Carefully";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(249, 122);
            label4.Name = "label4";
            label4.Size = new Size(379, 100);
            label4.TabIndex = 37;
            label4.Text = " *You are eligible for a refund\r\naccording to the terms of your ticket. \r\nThe refund may take up to 7-10 business \r\ndays to process.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(249, 235);
            label5.Name = "label5";
            label5.Size = new Size(355, 75);
            label5.TabIndex = 38;
            label5.Text = "*A cancellation fee may apply\r\ndepending on the time of cancellation \r\nand the type of ticket purchased.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(249, 321);
            label6.Name = "label6";
            label6.Size = new Size(424, 75);
            label6.TabIndex = 39;
            label6.Text = "* If you wish to reschedule your flight instead, \r\nplease go back to menu options and select \r\n\"Change Date\" Button\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(449, 398);
            label7.Name = "label7";
            label7.Size = new Size(508, 25);
            label7.TabIndex = 40;
            label7.Text = "Once you confirm the cancellation, it cannot be undone.";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(477, 449);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 42;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(249, 449);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 41;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_12_15_18_44_27;
            ClientSize = new Size(960, 521);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblCancel);
            Controls.Add(label2);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblCancel;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button1;
    }
}