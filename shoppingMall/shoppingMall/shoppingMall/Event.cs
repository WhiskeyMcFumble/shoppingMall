using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    internal class Event
    {
        protected string eventType = "";
        protected string EventType { get => eventType; set => eventType = value; }
        protected bool status { get; set; }
        protected DateTime time { get; set; }
        protected DateTime date { get; set; }
        protected int rating { get; set; }
        protected int visiters { get; set; }
        protected string organizer = "";
        protected string Organizer { get => organizer; set => organizer = value; }
        protected double cost { get; set; }
        protected int visitorIncrease { get; set; }

        public Event(string eventType, bool status, DateTime time, DateTime date, int rating, int visiters, string organizer, double cost, int visitorIncrease)
        {
            this.eventType = eventType;
            this.status = status;
            this.time = time;
            this.date = date;
            this.rating = rating;
            this.visiters = visiters;
            this.organizer = organizer;
            this.cost = cost;
            this.visitorIncrease = visitorIncrease;
        }


    }
}
