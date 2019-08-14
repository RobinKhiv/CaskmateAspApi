using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaskmateAspApi.Models
{
    public class Whiskey
    {
        public int Id { get; set; }
        public string Whiskey_Name { get; set; }
        public string Img { get; set; }
        public string Origin { get; set; }
        public decimal Abv { get; set; }
        public float Price { get; set; }
        public string Content { get; set; }
        public string Nose { get; set; }
        public string Palate { get; set; }
        public string Finish { get; set; }
        public string Username { get; set; }
    }
    public class WhiskeyReviews
    {
        public int Id { get; set;}
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
    }
}