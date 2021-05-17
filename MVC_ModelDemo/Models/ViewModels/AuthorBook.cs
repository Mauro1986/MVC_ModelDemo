using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_ModelDemo.Models;

namespace MVC_ModelDemo.ViewModels
{
    public class AuthorBook
    {
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
//Deze viewmodelsmap moeten eigenlijk 1 niveau hoger staan zoals in demo kenan