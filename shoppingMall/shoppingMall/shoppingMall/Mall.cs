using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    internal class Mall
    {
        private string name = "";

        protected string Name { get => name; set => name = value; }
    

        protected double capital { get; set; }
  
        protected double shopRevenueTotal { get; set; }
        protected int visitorCount { get; set; }
        protected int shopCount { get; set; }
        protected double workerPayment { get; set; }
        private double result;
        protected int rating { get; set; }

        public Mall(string name, double size, int capacity, string address, double capital, double rentAmount, bool status, double shopRevenueTotal, int shopCount, int visitorCount, double eventIncome, double workerPayment)
        {
            this.name = name;  
            this.capital = capital;
            this.shopRevenueTotal = shopRevenueTotal;
            this.shopCount = shopCount;
            this.visitorCount = visitorCount;
            this.workerPayment = workerPayment;
            this.rating = rating;
        }

       

    }
}
