using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    internal class Worker
    {
        protected string name = "";
        protected string Name { get => name; set => name = value; }
        protected int age { get; set; }
        protected int socialSecurityNumber { get; set; }
        protected string workField = "";
        protected string WorkField { get => workField; set => workField = value; }
        protected int weekHours { get; set; }
        protected string position = "";
        protected string Position { get => position; set => position = value;}
        protected int rating { get; set; }
        protected bool presentToday { get; set; }

        public Worker(string name, int age, int socialSecurityNumber, string workField, int weekHours, string position, int rating, bool presentToday)
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
