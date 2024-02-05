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

namespace shoppingMall
{
    public partial class WorkersPage : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eveline\\source\\repos\\shoppingMall2\\shoppingMall\\shoppingMall\\shoppingMall\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt2;
        SqlDataAdapter adapter;
        DataSet ds;
    
        public WorkersPage()
        {
            InitializeComponent();
           
            List<Worker> listWorker = new List<Worker>();
            con.Open();
            cmd = new SqlCommand("select * from Worker", con);
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "testTable");
            con.Close();
            dt2 = ds.Tables["testTable"];

           

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                listWorker.Add(new Worker(dt2.Rows[i]["name"].ToString(), (int)dt2.Rows[i]["age"], dt2.Rows[i]["socialSecurityNumber"].ToString(), dt2.Rows[i]["workField"].ToString(), (int)dt2.Rows[i]["weekHours"], dt2.Rows[i]["position"].ToString(), (double)dt2.Rows[i]["rating"]));
            }

            createPanels(listWorker);
        }


        private void createPanels(List<Worker> list)
        {
            foreach (Worker worker in list)

            {
                Panel panelStore = new Panel();
                panelStore.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Text = worker.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                button.Click += (sender, e) => openPage(worker, sender, e);
                panelStore.Controls.Add(button);
                panelWorkers.Controls.Add(panelStore);
            }
        }
        internal void openPage(Worker worker, object sender, EventArgs e)
        {

            DetailScreen f2 = new DetailScreen(worker);
            this.Hide();
            f2.ShowDialog();
        }

        private void WorkersPage_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            panel.Controls.Add(menu.createMenu());
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
