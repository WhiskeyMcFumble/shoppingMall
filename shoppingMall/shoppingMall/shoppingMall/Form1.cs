namespace shoppingMall
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Menu menu = new Menu();

            //Retrieve the FlowLayoutPanel with labels from the menu class
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();

            // Add the menu FlowLayoutPanel to the FlowLayoutPanel of this page
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
    }

}