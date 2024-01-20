using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    public class Shop
    {
        private string name = "";
        protected string Name { get => name; set => name = value; }
        private double size;
        protected string category;
        protected double averageVisitorRevenue { get; set; }
        protected bool status { get; set; }
        protected double capital { get; set; }
        protected int rating { get; set; }
        protected int averageVisitorCount { get; set; }
        protected double Size { get => size; set => size = value; }

        public string GetName()
        {
            return name;
        }
        public double GetSize()
        {
            return size;
        }

        public bool GetStatus()
        {
            return status;
        }

        public string GetCategory()
        {
            return category;
        }
        public double GetCapital()
        {
            return capital;
        }
        public int GetRating()
        {
            return rating;
        }

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

    }
}
