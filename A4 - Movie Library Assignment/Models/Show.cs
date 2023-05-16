using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4___Movie_Library_Assignment.Models
{
    internal class Show : Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }

    }
}
