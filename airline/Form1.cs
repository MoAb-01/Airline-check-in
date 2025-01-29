using System.Data.SQLite;
namespace airline
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnrLabel_Click(object sender, EventArgs e)
        {

        }

        private void helloLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextBut_Click(object sender, EventArgs e)
        {

        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //      NEXT Button   // 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            {
                string pnr = txtPNR.Text.Trim();
                string surname = txtLastName.Text.Trim();
                if (string.IsNullOrEmpty(pnr) || string.IsNullOrEmpty(surname))
                {
                    MessageBox.Show("Please fill in both fields.");
                    return;
                }
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM person WHERE PNR = @pnr AND Surname = @surname";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@pnr", pnr);
                            command.Parameters.AddWithValue("@surname", surname);

                            int result = Convert.ToInt32(command.ExecuteScalar());

                            if (result > 0)
                            {
                                MessageBox.Show("Welcome! Proceeding to your flight information");

                                Form2 form2 = new Form2(pnr, surname);
                                form2.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Invalid info! Please double check then retry");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: ", (ex.Message));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}


