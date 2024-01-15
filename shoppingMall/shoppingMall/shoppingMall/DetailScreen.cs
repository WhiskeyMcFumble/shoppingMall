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

        public DetailScreen(string name)
        {
            InitializeComponent();
            detail_name.Text = name;

        }



        private void name_store_Click(object sender, EventArgs e)
        {

        }


    }
}
