using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public int YearPublished { get; set; }
        public int Pages { get; set; }

    }
}
