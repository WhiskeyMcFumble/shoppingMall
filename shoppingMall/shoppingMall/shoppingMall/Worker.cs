using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    public class Worker
    {
        protected string name = "";
        protected string Name { get => name; set => name = value; }
        protected int age { get; set; }
        protected string socialSecurityNumber { get; set; }

        protected string workField = "";
        protected string WorkField { get => workField; set => workField = value; }
        protected int weekHours { get; set; }
        protected string position = "";
        protected string Position { get => position; set => position = value;}
        protected double rating { get; set; }
        protected bool presentToday { get; set; }


        public string GetName()
        {
            return this.name;
        }

        public Worker(string name, int age, string socialSecurityNumber, string workField, int weekHours, string position, double rating)
        {
            this.name = name;
            this.age = age;
            this.socialSecurityNumber = socialSecurityNumber;
            this.workField = workField;
            this.weekHours = weekHours;
            this.position = position;
            this.rating = rating;
            this.presentToday = presentToday;
        }
    }
}
