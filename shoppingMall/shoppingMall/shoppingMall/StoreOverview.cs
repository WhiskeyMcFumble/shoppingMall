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
    public partial class StoreOverview : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eveline\\source\\repos\\shoppingMall2\\shoppingMall\\shoppingMall\\shoppingMall\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommand cmd1;
        DataTable dt1;
        SqlDataAdapter adapter1;
        DataSet ds1;
        public StoreOverview()
        {
            List<Shop> list = new List<Shop>();


            con.Open();
            cmd = new SqlCommand("select * from Shop", con);
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "testTable");
            con.Close();
            dt = ds.Tables["testTable"];

            con.Open();
            cmd1 = new SqlCommand("select * from Restaurant", con);
            adapter1 = new SqlDataAdapter(cmd);
            ds1 = new DataSet();
            adapter1.Fill(ds1, "testTable1");
            con.Close();
            dt1 = ds1.Tables["testTable1"];


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["category"].ToString() == "Techstore")
                {
                    if (dt.Rows[i]["status"].ToString() == "true")
                    {
                        list.Add(new Techstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], true, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));
                    }
                    else
                    {
                        list.Add(new Techstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], false, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));

                    }
                }
                else if (dt.Rows[i]["category"].ToString() == "Drugstore")
                {
                    if (dt.Rows[i]["status"].ToString() == "true")
                    {
                        list.Add(new Drugstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], true, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));
                    }
                    else
                    {
                        list.Add(new Drugstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], false, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));

                    }
                }
                else if (dt.Rows[i]["category"].ToString() == "Clothstore")
                {
                    if (dt.Rows[i]["status"].ToString() == "true")
                    {
                        list.Add(new Clothstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], true, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));
                    }
                    else
                    {
                        list.Add(new Clothstore(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], false, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"]));

                    }
                }
                else if (dt.Rows[i]["category"].ToString() == "Restaurant")
                {
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        if (dt1.Rows[j]["shopId"] == dt.Rows[i]["Id"])
                        {
                            if (dt1.Rows[j]["healthInspection"].ToString() == "true")
                            {
                                if (dt.Rows[i]["status"].ToString() == "true")
                                {
                                    list.Add(new Restaurant(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], true, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"], true, 5));
                                    break;
                                }
                                else
                                {
                                    list.Add(new Restaurant(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], false, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"], true, 5));
                                    break;
                                }
                            }
                            else if (dt.Rows[j]["healthInspection"].ToString() == "false")
                            {
                                if (dt.Rows[i]["status"].ToString() == "true")
                                {
                                    list.Add(new Restaurant(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], true, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"], false, 5));
                                    break;
                                }
                                else
                                {
                                    list.Add(new Restaurant(dt.Rows[i]["Name"].ToString(), (double)dt.Rows[i]["size"], dt.Rows[i]["Category"].ToString(), (double)dt.Rows[i]["avgVisitorRevenue"], false, (decimal)dt.Rows[i]["Capital"], (double)dt.Rows[i]["Rating"], (double)dt.Rows[i]["avgVisitorCount"], false, 5));
                                    break;
                                }
                            }
                        }

                    }
                }
            }


            InitializeComponent();
            Menu menu = new Menu();
            FlowLayoutPanel menuFlowLayoutPanel = menu.createMenu();
            menu.EditButtonClicked += EditButton_Click;
            panel.Controls.Add(menuFlowLayoutPanel);
           createPanels(list);

          


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hallo");
        }


        private void createPanels(List<Shop> list)
        {
            foreach (Shop shop in list)

            {
                Panel panelStore = new Panel();
                panelStore.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Text = shop.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                //button.Click += (sender, e) => MessageBox.Show("Button " + (i + 1) + " clicked");
                panelStore.Controls.Add(button);
                formPanel.Controls.Add(panelStore);
            }
        }

        private void StoreOverview_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)

        {

        }



        /* private void jupiter_label_Click(object sender, EventArgs e)
         {
             string label = jupiter_label.Text;
             openPage(jupiter);
         }
        */
       // public void openPage(Shop shop)
        //{
        //    DetailScreen f2 = new DetailScreen(shop);
          //  f2.ShowDialog();
       // }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}