using MVC_ModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Repository
{
    public class PersonRepo
    {
        public List<Person> GetAllPersons()
        {
            return FakePersonDatabase();
        }
        private List<Person> FakePersonDatabase()
        {
            return new List<Person>()
            {
                new Person() {Id=1,Name="Mauro",Age=34,Gender="M"},
                new Person() {Id=2,Name="Emre",Age=41,Gender="M"},
                new Person() {Id=3,Name="Kenan",Age=20,Gender="M"},
                new Person() {Id=4,Name="Kadihja",Age=27,Gender="F"},
                new Person() {Id=5,Name="Inge",Age=52,Gender="F"},
            };
        }
    }
}
