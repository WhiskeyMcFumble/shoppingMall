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

      
       
        public WorkersPage()
        {
            InitializeComponent();


         
            Menu menu = new Menu();
            List<Worker> list = menu.listWorkers();
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();

            panel.Controls.Add(menuFlowLayoutPanel);
            createPanels(list);


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
            FormNavigationManager.SetPreviousForm(this);
            DetailScreen f2 = new DetailScreen(worker);
            this.Hide();
            f2.ShowDialog();
        }

        private void WorkersPage_Load(object sender, EventArgs e)
        {
           
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
