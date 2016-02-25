using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkProject.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public int BreweryID { get; set; }
    }
}