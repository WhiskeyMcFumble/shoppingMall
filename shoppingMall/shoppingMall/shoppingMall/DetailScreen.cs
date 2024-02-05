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
        }
        public DetailScreen(Worker worker)
        {
            InitializeComponent();
            detail_name.Text = worker.GetName();
           
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
            using (SqlCommand command = new SqlCommand("DELETE FROM Shop WHERE name = '" + detail_name.Text + "'", con))
            {
                command.ExecuteNonQuery();
            }
            con.Close();
            this.Hide();
            StoreOverview store = new StoreOverview();
            store.ShowDialog();


        }
    }
}