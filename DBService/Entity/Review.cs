using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService.Entity
{
   public class Review
    {
        // Define class properties
        public string Id { get; set; }
        public string Status { get; set; }
        public string Post { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string Desc { get; set; }

        public Review()
        {

        }

        public Review(string id, string status, string post, string author, string rating, string desc)
        {
            Id = id;
            Status = status;
            Post = post;
            Author = author;
            Rating = rating;
            Desc = desc;
        }
    }
}
    