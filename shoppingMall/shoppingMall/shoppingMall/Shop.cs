using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    internal class Shop
    {
        private string name = "";
        protected string Name { get => name; set => name = value; }
        protected double size { get; set; }
        protected string category { get => category; set => category = value; }
        protected double averageVisitorRevenue { get; set; }
        protected bool status { get; set; }
        protected double capital { get; set; }
        protected int rating { get; set; }
        protected int averageVisitorCount { get; set; }

        public Shop(string name, double size, string category, double averageVisitorRevenue, bool status, double capital, int rating, int averageVisitorCount)
        {
            this.name = name;
            this.size = size;
            this.category = category;
            this.averageVisitorCount = averageVisitorCount;
            this.status = status;
            this.capital = capital;
            this.rating = rating;
            this.averageVisitorCount = averageVisitorCount;
        }

#cool #2cool4school

    }
}
