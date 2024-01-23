namespace shoppingMall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stores_button_Click(object sender, EventArgs e)
        {
            StoreOverview storeOverview = new StoreOverview();
            storeOverview.ShowDialog();
        }
    }
}