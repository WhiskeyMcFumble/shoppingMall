using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingMall
{
    public partial class AddWorker : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eveline\\source\\repos\\shoppingMall2\\shoppingMall\\shoppingMall\\shoppingMall\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommand cmd1;
        DataTable dt1;
        SqlDataAdapter adapter1;
        DataSet ds1;
        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            object result = 0;
            using (SqlCommand command2 = new SqlCommand("SELECT MAX(id) FROM Shop", con))
            {
                con.Open();
                result = command2.ExecuteScalar();
                con.Close();

            }

            if (name.Text != "" && age.Text != "" && rating.Text != "" && field.Text != "")
            {
                double resulte = Convert.ToDouble(result);
                resulte = resulte + 1;

                using (SqlCommand command = new SqlCommand("INSERT INTO Worker (id, name, age, socialSecurityNumber, workField, weekHours, position, rating) VALUES (@id, @Name, @age, @socialSecurityNumber, @workField, @weekHours, @position, @rating)", con))
                {
                    command.Parameters.AddWithValue("@id", resulte);
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@age", Convert.ToInt32(age.Text)); // Assuming 'age' is a TextBox for age input
                    command.Parameters.AddWithValue("@socialSecurityNumber", 2345 + resulte);
                    command.Parameters.AddWithValue("@workField", field.Text);
                    command.Parameters.AddWithValue("@weekHours", Convert.ToInt32(workhours.Text)); // Assuming 'workhours' is a TextBox for work hours input
                    command.Parameters.AddWithValue("@position", position.Text);
                    command.Parameters.AddWithValue("@rating", Convert.ToDouble(rating.Text));

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Gespeichert");
                this.Hide();
                StoreOverview storeOverview = new StoreOverview();
                storeOverview.Show();
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }
    }

}
