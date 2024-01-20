namespace shoppingMall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Shop gameStore = new Shop("Game Store", 200, "store", 30, true, 300, 4,5);
        Shop jupiter = new Shop("Jupiter", 200, "store", 30, true, 300, 4, 5);




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void person_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void capital_label_Click(object sender, EventArgs e)
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