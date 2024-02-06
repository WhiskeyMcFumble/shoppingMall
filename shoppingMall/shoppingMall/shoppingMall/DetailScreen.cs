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
using System.Xml.Linq;
using YourNamespace;

namespace shoppingMall
{

    public partial class DetailScreen : BaseForm
    {



        public bool isShopDetail;

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eveline\\source\\repos\\shoppingMall2\\shoppingMall\\shoppingMall\\shoppingMall\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommand cmd1;
        DataTable dt1;
        SqlDataAdapter adapter1;
        DataSet ds1;


        public DetailScreen(Shop shop)
        {

            InitializeComponent();
            detail_name.Text = shop.GetName();
            size.Text = shop.GetSize().ToString();
            category.Text = shop.GetCategory();
            rating.Text = shop.GetRating().ToString();
            capital.Text = shop.GetCapital().ToString();
            saveButton.Visible = false;
            isShopDetail = true;
            saveButton.Visible = false;
            startMode();


        }


        public DetailScreen(Worker worker)
        {
            InitializeComponent();

            size_label.Text = "ID";
            category_label.Text = "Bewertung";
            capital_store_label.Text = "Alter";
            rating_store_label.Text = "Woche Stunden";

            detail_name.Text = worker.GetName();
            size.Text = worker.GetSsN().ToString();
            category.Text = worker.GetRating().ToString();
            rating.Text = worker.GetWeekHours().ToString();
            capital.Text = worker.GetAge().ToString();
            startMode();

        }

        public void startMode()
        {
            if (!isShopDetail)
            {
                editButton.Visible = false;
            }
            saveButton.Visible = false;
            sizeTextBox.Visible = false;
            sizeTextBox.PlaceholderText = size.Text;
            categoryTextBox.PlaceholderText = category.Text;
            ratingTextBox.PlaceholderText = rating.Text;
            capitalTextBox.PlaceholderText = capital.Text;
            categoryTextBox.Visible = false;
            ratingTextBox.Visible = false;
            capitalTextBox.Visible = false;

        }


        public void editMode()
        {
            saveButton.Visible = true;
            sizeTextBox.Visible = true;
            categoryTextBox.Visible = true;
            ratingTextBox.Visible = true;
            capitalTextBox.Visible = true;

        }

        private void name_store_Click(object sender, EventArgs e)
        {

        }

        private void DetailScreen_Load(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            con.Open();
            if (isShopDetail)
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Shop WHERE name = '" + detail_name.Text + "'", con))
                {
                    double capitalNumber = Convert.ToDouble(capital.Text);
                    double ratingNumber = Convert.ToDouble(rating.Text);
                    Menu menu = new Menu();
                    menu.setCapital(capitalNumber);
                    menu.setRating(ratingNumber);
                    command.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    StoreOverview store = new StoreOverview();
                    store.ShowDialog();

                }
            }
            else
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Worker WHERE name = '" + detail_name.Text + "'", con))
                {
                    command.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    WorkersPage store = new WorkersPage();
                    store.ShowDialog();
                }
            }

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();


            if (isShopDetail)
            {
                StoreOverview store = new StoreOverview();
                store.ShowDialog();
            }

            else
            {
                WorkersPage store = new WorkersPage();
                store.ShowDialog();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editMode();



        }

        private void save_Click(object sender, EventArgs e)
        {
            if (isShopDetail)
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Shop SET category = @Category, rating = @Rating, size = @Size, capital = @Capital WHERE name = @Name", con))
                {
                    command.Parameters.AddWithValue("@Size", float.Parse(sizeTextBox.Text));
                    command.Parameters.AddWithValue("@Category", categoryTextBox.Text);
                    command.Parameters.AddWithValue("@Rating", Convert.ToDouble(ratingTextBox.Text));
                    command.Parameters.AddWithValue("@Capital", Convert.ToDouble(capital.Text));
                    command.Parameters.AddWithValue("@Name", detail_name.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Gespeichert");
                }
            }
        }
    }
}


