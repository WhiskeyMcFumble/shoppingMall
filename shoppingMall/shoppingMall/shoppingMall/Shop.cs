using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    public abstract class Shop
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

    }
}