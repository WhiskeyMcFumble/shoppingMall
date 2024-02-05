using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingMall
{
    internal class Menu
    {

        protected double capital;
        protected double rating;
        protected Button delete;
        FlowLayoutPanel flowPannel = new FlowLayoutPanel();
        public event EventHandler EditButtonClicked;

        public double getRating()
        {
            return this.rating;
        }

        public double getCapital()
        {
            return this.capital;
        }
        public void setRating(double rating)
        {
            this.rating = rating;
        }
        public void setCapital(double capital)
        {
            this.capital = capital;
        }

        public FlowLayoutPanel createMenu()
        {


            Label capitalLabel = new Label();
            Label capitalName = new Label();
            Label ratingName = new Label();
            capitalName.Text = "Kapital:";
            ratingName.Text = "Rating";
            capitalLabel.Text = this.capital.ToString();
            Label ratingLabel = new Label();
            ratingLabel.Text = this.rating.ToString();
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Click += EditButton_Click;




            flowPannel.Controls.Add(capitalName);
            flowPannel.Controls.Add(capitalLabel);
            flowPannel.Controls.Add(ratingName);
            flowPannel.Controls.Add(ratingLabel);
            flowPannel.Controls.Add(editButton);
            //flowPannel.Controls.Add(editButton);
            return flowPannel;
        }


        public void EditButton_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            flowPannel.Controls[0].Controls.Add(deleteButton);



        }
        public void deleteButton_Click(object sender, EventArgs e)
        {

        }

        public Menu()
        {
            this.capital = 10000;
            this.rating = 3.5;
        }

    }
}
