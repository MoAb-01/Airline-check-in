using System.Data.SQLite;
using System.Windows.Forms;


namespace airline
{
    public partial class Form5 : Form
    {
        private string pnr;
        private string surname;

        public Form5(string pnr, string surname)
        {
            InitializeComponent();
            this.pnr = pnr;
            this.surname = surname;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Date FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the Date in the label
                                lblDate.Text = reader["Date"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

                //    Confirm Button   //
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime newDate = dateTimePicker1.Value;
            if (newDate < new DateTime(2024, 12, 23) || newDate > new DateTime(2026, 12, 31))
            {
                MessageBox.Show("Please choose a date between December 2024 and December 2026!");
                return;
            }
            else
            {

                    //       Update the label       //
                    lblDate.Text = newDate.ToString("yyyy-MM-dd");

                    //     Update the database with the new date   //
                    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                    try
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                        {
                            connection.Open();
                            string updateQuery = "UPDATE person SET Date = @newDate WHERE PNR = @pnr AND Surname = @surname";
                            using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@newDate", newDate.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@pnr", pnr);
                                command.Parameters.AddWithValue("@surname", surname);

                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Flight date changed successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error the updating database: " + ex.Message);
                    }
                }
            }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
                    //    Back Button   //
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 previous = new Form2(pnr, surname);
            previous.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }
    }
}
