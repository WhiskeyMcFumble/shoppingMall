namespace shoppingMall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Shop gameStore = new Shop();




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
            openPage(label);
        }

        private void jupiter_label_Click(object sender, EventArgs e)
        {
            string label = jupiter_label.Text;
            openPage(label);
        }
        public void openPage(string name)
        {
            DetailScreen f2 = new DetailScreen(name);
            f2.ShowDialog();
        }
    }
}