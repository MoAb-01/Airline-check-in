using System.Data.SQLite;


namespace airline
{
    public partial class Form4 : Form
    {
        private string pnr;
        private string surname;
        public Form4(string pnr, string surname)
        {
            InitializeComponent();
            this.pnr = pnr;
            this.surname = surname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //      establish the connection     //
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Seat FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //    Display the seat number on our label   //
                                lblSeat.Text = reader["Seat"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
            comboBox1.Items.Add("1A");
            comboBox1.Items.Add("2A");
            comboBox1.Items.Add("3A");
            comboBox1.Items.Add("4A");
            comboBox1.Items.Add("5A");
            comboBox1.Items.Add("6A");
            comboBox1.Items.Add("7A");
            comboBox1.Items.Add("8A");
            comboBox1.Items.Add("9A");
            comboBox1.Items.Add("10A");
            comboBox1.Items.Add("1B");
            comboBox1.Items.Add("2B");
            comboBox1.Items.Add("3B");
            comboBox1.Items.Add("4B");
            comboBox1.Items.Add("5B");
            comboBox1.Items.Add("6B");
            comboBox1.Items.Add("7B");
            comboBox1.Items.Add("8B");
            comboBox1.Items.Add("9B");
            comboBox1.Items.Add("10B");
            comboBox1.Items.Add("1C");
            comboBox1.Items.Add("2C");
            comboBox1.Items.Add("3C");
            comboBox1.Items.Add("4C");
            comboBox1.Items.Add("5C");
            comboBox1.Items.Add("6C");
            comboBox1.Items.Add("7C");
            comboBox1.Items.Add("8C");
            comboBox1.Items.Add("9C");
            comboBox1.Items.Add("10C");
            comboBox1.Items.Add("1D");
            comboBox1.Items.Add("2D");
            comboBox1.Items.Add("3D");
            comboBox1.Items.Add("4D");
            comboBox1.Items.Add("5D");
            comboBox1.Items.Add("6D");
            comboBox1.Items.Add("7D");
            comboBox1.Items.Add("8D");
            comboBox1.Items.Add("9D");
            comboBox1.Items.Add("10D");
            comboBox1.Items.Add("1F");
            comboBox1.Items.Add("2F");
            comboBox1.Items.Add("3F");
            comboBox1.Items.Add("4F");
            comboBox1.Items.Add("5F");
            comboBox1.Items.Add("6F");
            comboBox1.Items.Add("7F");
            comboBox1.Items.Add("8F");
            comboBox1.Items.Add("9F");
            comboBox1.Items.Add("10F");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
         //     Confirm Button     //
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedSeat = comboBox1.SelectedItem.ToString();
                lblSeat.Text = selectedSeat;


                // Update the label with the selected seat
                lblSeat.Text = selectedSeat;

                //   Updating the db   //
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE person SET Seat = @seat WHERE PNR = @pnr AND Surname = @surname";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@seat", selectedSeat);
                            command.Parameters.AddWithValue("@pnr", pnr);
                            command.Parameters.AddWithValue("@surname", surname);

                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Success! Your seat has been changed.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating seat: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a seat option.");
            }
        }


        //     Back Button    //
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 previous = new Form2(pnr, surname);
            previous.Show();
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}