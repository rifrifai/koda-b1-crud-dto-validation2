using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class CatalogController(IProductService service) : Controller
{
	private readonly IProductService _service = service;

	[HttpGet("/catalog")]
	public IActionResult Index()
	{
		var products = _service.GetProducts();

		return View(products);
	}
}