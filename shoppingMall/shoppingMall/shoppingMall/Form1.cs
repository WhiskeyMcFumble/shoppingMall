using System.Data;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace shoppingMall
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            Menu menu = new Menu();


            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();

            panel.Controls.Add(menuFlowLayoutPanel);



        }


        private void workerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void store_button_Click(object sender, EventArgs e)
        {
            StoreOverview storeOverview = new StoreOverview();
            this.Hide();
            storeOverview.ShowDialog();
        }

        private void workers_button_Click_1(object sender, EventArgs e)
        {
            WorkersPage workersOverview = new WorkersPage();
            this.Hide();
            workersOverview.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}