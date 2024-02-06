using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingMall
{
    internal class Menu
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


        public List<Shop> listShop()
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
             return list;
        }

        public List<Worker> listWorkers()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eveline\\source\\repos\\shoppingMall2\\shoppingMall\\shoppingMall\\shoppingMall\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            DataTable dt2;
            SqlDataAdapter adapter;
            DataSet ds;

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

            return listWorker;

        }




        protected double capital;
        protected double rating;
       
        FlowLayoutPanel flowPannel = new FlowLayoutPanel();
        public event EventHandler BackButtonClicked;

        public double getRating()
        {
            return this.rating;
        }

        public double getCapital()
        {
            return this.capital;
        }
        public void setRating(double ratings)
        {
            this.rating = ratings;
        }
        public void setCapital(double capitals)
        {
            this.capital = capitals;
        }

        public FlowLayoutPanel createMenu()
        {

            flowPannel.Size = new System.Drawing.Size(700, 32);
            
            Label capitalLabel = new Label();
            Label capitalName = new Label();
            Label ratingName = new Label();

            capitalName.Text = "Kapital:";
            ratingName.Text = "Rating:";
            capitalLabel.Text = calculateTotalCapital(listShop(), listWorkers()).ToString();
            Label ratingLabel = new Label();
            ratingLabel.Text = calculateTotalRating(listShop(), listWorkers()).ToString();
            Button backButton = new Button();
            backButton.Text = "Back";
            backButton.Click += BackButton_Click;

            flowPannel.Controls.Add(capitalName);
            flowPannel.Controls.Add(capitalLabel);
            flowPannel.Controls.Add(ratingName);
            flowPannel.Controls.Add(ratingLabel);
            flowPannel.Controls.Add(backButton);
            return flowPannel;
        }

        public void BackButton_Click(object sender, EventArgs e)

        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
            FormNavigationManager.NavigateBack();
           

        }


        public void EditButton_Click(object sender, EventArgs e)
        {


            MessageBox.Show("a");


        }
       

        public double calculateShopCapital(List<Shop> list)
        {
           
            double rent = 5000;
            double result = 0;
            foreach (Shop shop in list)

            {
                result += rent + (0.2 * Convert.ToDouble(shop.GetCapital()));

            }
            return Math.Round(result, 2); ;
           
           
        }

        public double calculateTotalCapital(List<Shop> listShops, List<Worker> listWorkers)
        {
           double total = 0;
           
           double shopCapital = calculateShopCapital(listShops);


            foreach (Worker worker in listWorkers)

            {
                total += Convert.ToDouble(worker.GetWeekHours() * 12);

            }

            double result = shopCapital - total;
            Math.Round(result, 2);

            return Math.Round(result, 2); ;
        }

        public double calculateShopRating(List<Shop> list)
        {
            list = listShop();
            double count = list.Count();
            double ratingShops = 0;
            foreach (Shop shop in list)

            {
                ratingShops += shop.GetRating();

            }

            double result = ratingShops / count;
           
            return Math.Round(result, 2); ;
        }

        public double calculateTotalRating(List<Shop> listShops, List<Worker> listWorkers)
        {
            double total = 0;

            double shopCapital = calculateShopRating(listShops);
           
            foreach (Worker worker in listWorkers)

            {

                total += worker.GetRating();

            }

          
            total = total / listWorkers.Count();
         
            double result = (shopCapital + total) / 2;
           
            return Math.Round(result, 2); ;
        }

       

        public Menu()
        {
            this.capital = 10000;
            this.rating = 3.5;
        }

    }
}
