using Microsoft.AspNetCore.Mvc;
using MVC_ModelDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonRepo _personRepository = new PersonRepo();

        public IActionResult Index()
        {
            var personen = _personRepository.GetAllPersons();

            return View(personen);
        }
    }
}
