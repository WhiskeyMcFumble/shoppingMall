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
using YourNamespace;

namespace shoppingMall
{
    public partial class StoreOverview : BaseForm
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



        public StoreOverview()
        {


            InitializeComponent();

            Menu menu = new Menu();
            List<Shop> list = menu.listShop();
            menu.BackButtonClicked += BackButton_Click;

            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();

            panel.Controls.Add(menuFlowLayoutPanel);
            createPanels(list);

        }



        private void EditButton_Click(object sender, EventArgs e)
        {

            Add add = new Add();
            this.Hide();
            add.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();


        }



        private void createPanels(List<Shop> list)
        {
            foreach (Shop shop in list)

            {
                Panel panelStore = new Panel();
                panelStore.BackColor = Color.White;
                panelStore.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Size = new System.Drawing.Size(100, 100);
                button.Location = new Point((panelStore.Width - button.Width) / 2, (panelStore.Height - button.Height) / 2);
                button.Text = shop.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                button.Click += (sender, e) => openPage(shop, sender, e);
                panelStore.Controls.Add(button);
                formPanel.Controls.Add(panelStore);
            }
        }


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

        private void addButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.ShowDialog();
        }

        private void formPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}