using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService.Entity
{
    public class Gem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime? Date { get; set; }
        public float? Rating { get; set; }
        public string Partner { get; set; }


        public Gem()
        {

        }

        public Gem(string title, string description, string type, string location, DateTime? date, string partner)
        {
            Title = title;
            Description = description;
            Type = type;
            Location = location;
            Date = date;
            // default status when created is Active | when activity type is over/company disables gem, status is "disabled"
            Status = "Active";
            Rating = null;
            Partner = partner;
        }


        //end
    }


}
