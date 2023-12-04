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
        protected double size { get; set; }
        protected int capacity { get; set; }
        protected string address = "";
        protected string Address { get => address; set => address = value; }
        protected double capital { get; set; }
        protected double rentAmount { get; set; }
        protected bool status { get; set; }
        protected double shopRevenueTotal { get; set; }
        protected int visitorCount { get; set; }
        protected int shopCount { get; set; }
        protected double eventIncome { get; set; }
        protected double workerPayment { get; set; }
        private double result;
        protected int rating { get; set; }

        public Mall(string name, double size, int capacity, string address, double capital, double rentAmount, bool status, double shopRevenueTotal, int shopCount, int visitorCount, double eventIncome, double workerPayment)
        {
            this.name = name;
            this.size = size;
            this.capacity = capacity;
            this.address = address;
            this.capital = capital;
            this.rentAmount = rentAmount;
            this.status = status;
            this.shopRevenueTotal = shopRevenueTotal;
            this.shopCount = shopCount;
            this.visitorCount = visitorCount;
            this.eventIncome = eventIncome;
            this.workerPayment = workerPayment;
            this.rating = rating;
        }

        public double calculateCapital(double capital, double rentAmount, int shopCount, double shopRevenueTotal, double eventIncome, double workerPayment)
        {
            capital += capital + (rentAmount * shopCount) + shopRevenueTotal + eventIncome - workerPayment;
            return capital;
        }
                                                                                 
        public double calculateMonthlyIncome(double rentAmount, int shopCount, double shopRevenueTotal, double eventIncome, double workerPayment)
        {
            result = (rentAmount * shopCount) + shopRevenueTotal + eventIncome - workerPayment;
            return result;
        }

    }
}
