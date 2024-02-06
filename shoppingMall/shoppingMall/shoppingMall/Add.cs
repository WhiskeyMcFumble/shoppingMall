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
using YourNamespace;

namespace shoppingMall
{
    public partial class Add : BaseForm
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

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)

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

            if (name.Text != "" && category.Text != "" && rating.Text != "" && capital.Text != "")
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Shop (id, name, category, size, status, rating, capital, avgVisitorCount, avgVisitorRevenue) VALUES ( @id ,@Name, @Category,@size, @status, @Rating, @Capital, @avgVisitorCount, @avgVisitorRevenue)", con))
                {
                    double resulte = Convert.ToDouble(result);
                    resulte = resulte + 1;

                    command.Parameters.AddWithValue("@id", resulte);
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Category", category.Text);
                    command.Parameters.AddWithValue("@size", 23);
                    command.Parameters.AddWithValue("@status", "true");
                    command.Parameters.AddWithValue("@avgVisitorCount", 20);
                    command.Parameters.AddWithValue("@avgVisitorRevenue", 20);

                    double ratingValue;
                    if (double.TryParse(rating.Text, out ratingValue))
                    {
                        command.Parameters.AddWithValue("@rating", ratingValue);
                    }
                    else
                    {
                        MessageBox.Show("Rating fehlt");
                        return;
                    }

                    decimal capitalValue;
                    if (decimal.TryParse(capital.Text, out capitalValue))
                    {
                        command.Parameters.AddWithValue("@capital", capitalValue);
                    }
                    else
                    {
                        MessageBox.Show("Kapital fehlt");
                        return;
                    }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StoreOverview storeOverview = new StoreOverview();
            this.Hide();
            storeOverview.Show();
        }
    }
}
