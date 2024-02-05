using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingMall
{
    public partial class StoreOverview : Form
    {
        public StoreOverview()
        {
            InitializeComponent();
            Menu menu = new Menu();
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();
            menu.EditButtonClicked += EditButton_Click;
            panel.Controls.Add(menuFlowLayoutPanel);

        }

        Shop gameStore = new Shop("Game Store", 200, "store", 30, true, 300, 4, 5);
        Shop jupiter = new Shop("Jupiter", 200, "store", 30, true, 300, 4, 5);

        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hallo");


        }
        private void StoreOverview_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)

        {

        }



        /* private void jupiter_label_Click(object sender, EventArgs e)
         {
             string label = jupiter_label.Text;
             openPage(jupiter);
         }
        */
        public void openPage(Shop shop)
        {
            DetailScreen f2 = new DetailScreen(shop);
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
    }


}