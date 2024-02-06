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
using YourNamespace;

namespace shoppingMall
{
    public partial class WorkersPage : BaseForm
    {



        public WorkersPage()
        {
            InitializeComponent();
            Menu menu = new Menu();
            List<Worker> list = menu.listWorkers();
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();
            menu.BackButtonClicked += BackButton_Click;
            panel.Controls.Add(menuFlowLayoutPanel);
            createPanels(list);

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();


        }

   
        private void createPanels(List<Worker> list)
        {
            foreach (Worker worker in list)


            {
                Panel panelStore = new Panel();
                panelStore.BackColor = Color.White;
                panelStore.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Size = new System.Drawing.Size(100, 50);
                button.Location = new Point((panelStore.Width - button.Width) / 2, (panelStore.Height - button.Height) / 2);
                button.Text = worker.GetName();
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

        private void add_Click(object sender, EventArgs e)
        {
            AddWorker worker = new AddWorker();
            this.Hide();
            worker.ShowDialog();
        }
    }
}
