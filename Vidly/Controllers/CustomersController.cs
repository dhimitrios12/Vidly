using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		// GET: Customers
		public ActionResult Index()
		{
			return View(GetCustomers());
		}

		[Route("customers/details/{id}")]
		public ActionResult Details(int id)
		{
			var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
			if (customer == null)
			{
				return HttpNotFound();
			}

			return View(customer);
		}

		public List<Customer> GetCustomers()
		{
			List<Customer> customers = new List<Customer>
			{
				new Customer {Id = 1, Name = "Mark Benkol"},
				new Customer {Id = 2, Name = "Lompard Tendina"}
			};

			return customers;
		}
	}
}