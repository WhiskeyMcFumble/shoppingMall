using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingMall
{
    public partial class StoreOverview : Form, IPanelCreator
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


        public StoreOverview(double capital, double rating)
        {
           
           
           
            Menu menu = new Menu();
            menu.setRating(rating);
            menu.setCapital(capital);
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();
            menu.EditButtonClicked += EditButton_Click;
            //displayData(menuFlowLayoutPanel);
            

        }
            public StoreOverview()
        {


            InitializeComponent();
            Menu menu = new Menu();
            List<Shop> list = menu.listShop();
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();

            panel.Controls.Add(menuFlowLayoutPanel);
            createPanels(list);

        }

       

        private void EditButton_Click(object sender, EventArgs e)
        {
           
        }


        private void createPanels(List<Shop> list)
        {
            foreach (Shop shop in list)

            {
                Panel panelStore = new Panel();
                panelStore.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Text = shop.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                button.Click += (sender, e) => openPage(shop, sender, e);
                panelStore.Controls.Add(button);
                formPanel.Controls.Add(panelStore);
            }
        }
        /*
        public void CreatePanels<T>(List<T> items, Panel formPanel) where T : INameable
        {
            foreach (T item in items)
            {
                Panel panelItem = new Panel();
                panelItem.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Text = item.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                button.Click += (sender, e) => openPage(item, sender, e);
                panelItem.Controls.Add(button);
                formPanel.Controls.Add(panelItem);
            }
}
        */

private void StoreOverview_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)

        {

        }

        internal void openPage(Shop shop, object sender, EventArgs e)
        {

            DetailScreen f2 = new DetailScreen(shop);
            this.Hide();
            f2.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}