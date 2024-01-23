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
        }

        Shop gameStore = new Shop("Game Store", 200, "store", 30, true, 300, 4, 5);
        Shop jupiter = new Shop("Jupiter", 200, "store", 30, true, 300, 4, 5);


        private void StoreOverview_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void game_store_label_Click(object sender, EventArgs e)

        {
            string label = game_store_label.Text;
            openPage(gameStore);
        }

        private void jupiter_label_Click(object sender, EventArgs e)
        {
            string label = jupiter_label.Text;
            openPage(jupiter);
        }

        public void openPage(Shop shop)
        {
            DetailScreen f2 = new DetailScreen(shop);
            f2.ShowDialog();
        }

       
    }
}
