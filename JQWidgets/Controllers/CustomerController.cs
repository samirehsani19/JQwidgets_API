using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using JQWidgets.Models;
using System.Text.Json;

namespace JQWidgets.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "Samir", Age = 25, Gender = Gender.Male},
                new Customer{Id = 2, Name = "Markus", Age = 20, Gender = Gender.Male},
                new Customer{Id = 3, Name = "Hamid", Age = 25, Gender = Gender.Male},
                new Customer{Id = 4, Name = "Samira", Age = 25, Gender = Gender.Female},
                new Customer{Id = 5, Name = "Hanna", Age = 35, Gender = Gender.Female},
                new Customer{Id = 6, Name = "Isaq", Age = 23, Gender = Gender.Male},
                new Customer{Id = 7, Name = "Anders", Age = 45, Gender = Gender.Male},
                new Customer{Id = 8, Name = "Imma", Age = 25, Gender = Gender.Female},
                new Customer{Id = 9, Name = "Robert", Age = 18, Gender = Gender.Male},
                new Customer{Id = 10, Name = "Gustav", Age = 27, Gender = Gender.Male},
                new Customer{Id = 11, Name = "Jolly", Age = 23, Gender = Gender.Female},
                new Customer{Id = 12, Name = "Jahn", Age = 36, Gender = Gender.Male},
                new Customer{Id = 13, Name = "Pernilla", Age = 34, Gender = Gender.Female},
                new Customer{Id = 14, Name = "Per", Age = 37, Gender = Gender.Male},
                new Customer{Id = 15, Name = "Gunilla", Age = 47, Gender = Gender.Female},
            };
        }

    }
}
