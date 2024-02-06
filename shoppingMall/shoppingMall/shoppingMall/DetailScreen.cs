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

namespace shoppingMall
{

    public partial class DetailScreen : Form
    {
       
        public IBackButton backButtonManager;

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

            isShopDetail = true;



        }
        public void SetBackButtonManager(IBackButton backButtonManager)
        {
            this.backButtonManager = backButtonManager;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
           // FormNavigationManager.GoBack(this);
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

            Form previousForm = FormNavigationManager.GetPreviousForm(); 
            previousForm.Show(); 
            this.Close();
        }
    }
}