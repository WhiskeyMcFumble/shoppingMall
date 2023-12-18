using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    internal class Restaurant
    {
        //Ja
        protected string name = "";
        protected string Name { get => name; set => name = value; }
        protected double size { get; set; }
        protected string category { get => category; set => category = value; }
        protected double averageVisitorRevenue { get; set; }
        protected bool status { get; set; }
        protected double capital { get; set; }
        protected int rating { get; set; }
        protected bool healthInspection { get; set; }
        protected int stars { get; set; }

        public Restaurant(string name, double size, string category, double averageVisitorRevenue, bool status, double capital, int rating, bool healthInspection, int stars)
        {
            this.name = name;
            this.size = size;
            this.category = category;
            this.averageVisitorRevenue = averageVisitorRevenue;
            this.status = status;
            this.capital = capital;
            this.rating = rating;
            this.healthInspection = healthInspection;
            this.stars = stars;
        }

    }
}
