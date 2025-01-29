using System.Data.SQLite;
namespace airline
{
    public partial class Form2 : Form
    {
        private string pnr;
        private string surname;

        public Form2(string pnr, string surname)
        {
            InitializeComponent();
            this.pnr = pnr;
            this.surname = surname;
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            //     establisht the connection     //
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PNR, Surname, Baggage, FlightName, Destination, Date, Seat FROM person WHERE PNR = @pnr AND Surname = @surname";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pnr", pnr);
                        command.Parameters.AddWithValue("@surname", surname);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblSurname.Text = reader["Surname"].ToString();
                                lblBaggage.Text = reader["Baggage"].ToString();
                                lblFlightName.Text = reader["FlightName"].ToString();
                                lblDestination.Text = reader["Destination"].ToString();
                                lblDate.Text = reader["Date"].ToString();
                                lblSeat.Text = reader["Seat"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database:",ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblBaggage_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void seatLbl_Click(object sender, EventArgs e)
        {

        }
             //           Exit Button          //
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butFlight_Click(object sender, EventArgs e)
        {

        }

        private void butSeat_Click(object sender, EventArgs e)
        {

        }

        private void butDate_Click(object sender, EventArgs e)
        {

        }
                        //  Add Extra Weight Button  //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                Form3 form3 = new Form3(pnr, surname); //  passing info to Form 3  //
                this.Hide();
                form3.ShowDialog();
            }
        }
                    //       Change Seat         //
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            {
                Form4 form4 = new Form4(pnr, surname); //  passing info to Form 4 //
                this.Hide();
                form4.ShowDialog();
            }
        }
                     //         Change Date Button       //
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(pnr, surname); //   passing info to Form 5 //
            this.Hide();
            form5.ShowDialog();
        }
                //          Cancel Flight Button          //
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(pnr, surname); //  passing info to Form 6 //
            this.Hide();
            form6.ShowDialog();
        }
    }
}

