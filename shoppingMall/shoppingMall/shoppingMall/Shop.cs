using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    abstract class Shop
    {
        protected string name = "";
        protected string Name { get => name; set => name = value; }
        protected double size;
        protected string category;
        protected double averageVisitorRevenue { get; set; }
        protected bool status { get; set; }
        protected decimal capital { get; set; }
        protected double rating { get; set; }
        protected double averageVisitorCount { get; set; }
        protected double Size { get => size; set => size = value; }

        public abstract string GetName();
        public abstract double GetSize();

        public abstract bool GetStatus();

        public abstract string GetCategory();
        public abstract decimal GetCapital();
        public abstract double GetRating();

        /*       public Shop(string name, double size, string category, double averageVisitorRevenue, bool status, double capital, int rating, int averageVisitorCount)
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
       */
    }
}