using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4___Movie_Library_Assignment.Models
{
    internal class Video : Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }


    }
}
