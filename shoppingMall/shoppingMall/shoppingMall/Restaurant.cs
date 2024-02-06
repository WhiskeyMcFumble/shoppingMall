using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    //Hier kÃ¶nnte ihr Restaurant stehen
    internal class Restaurant : Shop
    {
        public override string GetName()
        {
            return name;
        }
        public override double GetSize()
        {
            return size;
        }

        public override bool GetStatus()
        {
            return status;
        }

        public override string GetCategory()
        {
            return category;
        }
        public override decimal GetCapital()
        {
            return capital;
        }
        public override double GetRating()
        {
            return rating;
        }

       

        public Restaurant(string name, double size, string category, double averageVisitorRevenue, bool status, decimal capital, double rating, double averageVisitorCount)
        {
            this.name = name;
            this.size = size;
            this.category = category;
            this.averageVisitorRevenue = averageVisitorRevenue;
            this.status = status;
            this.capital = capital;
            this.rating = rating;
            this.averageVisitorCount = averageVisitorCount;
           
        }

    }
}