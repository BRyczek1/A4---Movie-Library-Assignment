using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4___Movie_Library_Assignment.Models
{
    public class Movie : Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string[] Genre { get; set; }
    }
}
