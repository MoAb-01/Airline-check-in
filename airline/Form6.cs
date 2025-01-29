using System.Data.SQLite;
namespace airline
{
    public partial class Form6 : Form
    {
        private string pnr;
        private string surname;
        public Form6(string pnr, string surname)
        {
            InitializeComponent();
            this.pnr = pnr;
            this.surname = surname;
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //    establish the connection to the db //
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open(); 
                    string query = "SELECT FlightName FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //      Display the FlightName on our label   //
                                lblCancel.Text = reader["FlightName"].ToString();
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
                 //     Confirm Button     //
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your Flight has been canceled successfully");
                        }
                        else
                        {
                            MessageBox.Show("No matching user found to delete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user information: " + ex.Message);
            }

            Application.Exit(); // Close the application or return to previous form
        }
        
                 //         Back Button         //
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 previous = new Form2(pnr, surname);
            previous.Show();
            this.Close();
        }
    }
}
