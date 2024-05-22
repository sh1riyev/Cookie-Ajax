using System;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFront.Controllers
{
	public class ProductController :Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

