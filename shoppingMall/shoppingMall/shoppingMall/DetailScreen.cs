using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public DetailScreen(Shop shop)
        {
            InitializeComponent();
            detail_name.Text = shop.GetName();
            size.Text = shop.GetSize().ToString();
            category.Text = shop.GetCategory();
            rating.Text = shop.GetRating().ToString();
            capital.Text = shop.GetCapital().ToString();
        }

        private void name_store_Click(object sender, EventArgs e)
        {

        }

        private void DetailScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
