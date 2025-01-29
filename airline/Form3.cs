using System.Data.SQLite;
namespace airline
{

    public partial class Form3 : Form
    {
        private string pnr;
        private string surname;
        public int currentWeight;
        public Form3(string pnr, string surname)
        {
            InitializeComponent();
            this.pnr = pnr;
            this.surname = surname;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Baggage FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblWeight.Text = reader["Baggage"].ToString() + " kg";
                                currentWeight = Convert.ToInt32(reader["Baggage"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }

            comboBox1.Items.Add("10 kg for $30");
            comboBox1.Items.Add("15 kg for $60");
            comboBox1.Items.Add("20 kg for $120");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                  //       Confirm Button       //
        private void button1_Click(object sender, EventArgs e)
        {     //       If user did select an option        //
            if (comboBox1.SelectedItem != null)
            {
                // Detirmine the option that user has chosen  //
                int AddWeight1 = 10;
                int AddWeight2 = 15;
                int AddWeight3 = 20;
                string selectedOption = comboBox1.SelectedItem.ToString();
                int additionalWeight = 0;

                if (selectedOption == "10 kg for $30")
                {
                    additionalWeight = AddWeight1;
                }
                else if (selectedOption == "15 kg for $60")
                {
                    additionalWeight = AddWeight2;
                }
                else if (selectedOption == "20 kg for $120")
                {
                    additionalWeight = AddWeight3;
                }
                //     Updating the db     //
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        // Retrieve current baggage weight
                        string query = "SELECT Baggage FROM person WHERE PNR = @pnr AND Surname = @surname";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@pnr", pnr);
                            command.Parameters.AddWithValue("@surname", surname);

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblWeight.Text = reader["Baggage"].ToString() + " kg";
                                    currentWeight = Convert.ToInt32(reader["Baggage"]);
                                }
                            }
                        }

                        // Calculate new weight //
                        int newWeight = currentWeight + additionalWeight;

                        //  Update the baggage weight  //
                        string queryUpdate = "UPDATE person SET Baggage = @newWeight WHERE PNR = @pnr AND Surname = @surname";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(queryUpdate, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@newWeight", newWeight);
                            updateCommand.Parameters.AddWithValue("@pnr", pnr);
                            updateCommand.Parameters.AddWithValue("@surname", surname);

                            updateCommand.ExecuteNonQuery();
                        }

                        // Update the label to show new weight //
                        lblWeight.Text = newWeight + " kg";
                        MessageBox.Show("Success! Your extra baggage has been added.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating baggage weight: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an extra baggage option");
            }
        }
         //    Back Button    //
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 previous= new Form2(pnr,surname);
            previous.Show();
            this.Close();
        }
    }
}


