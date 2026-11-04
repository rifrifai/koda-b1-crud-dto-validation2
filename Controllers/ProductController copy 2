using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public sealed class ProductController(IProductService service) : ControllerBase
	{
		private readonly IProductService _service = service;

		[HttpGet]
		[ProducesResponseType(typeof(IReadOnlyList<ProductResponse>), StatusCodes.Status200OK)]
		public ActionResult<IReadOnlyList<Product>> GetAll()
		{
			return Ok(_service.GetProducts());
		}

		[HttpGet("{productID}")]
		[ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
		public ActionResult<ProductResponse> GetProduct([FromRoute] string productID)
		{
			var product = _service.GetProduct(productID);

			return product is not null ? Ok(product) : Problem(
					statusCode: StatusCodes.Status404NotFound,
					title: "Product does not exist"
				);
		}

		[HttpPost]
		[ProducesResponseType(typeof(ProductResponse), StatusCodes.Status201Created)]
		[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
		public ActionResult<ProductResponse> Create([FromBody] ProductRequest request)
		{
			try
			{
				var product = _service.Create(request);

				if (product is null)
				{
					return Problem(
						statusCode: StatusCodes.Status400BadRequest,
						title: "Product ID has already exist"
					);
				}
				return CreatedAtAction(
					actionName: nameof(GetProduct),
					routeValues: new {productID = product.ProductID},
					product
				);
			}
			catch (ArgumentException e)
			{
				return Problem(
					statusCode: StatusCodes.Status400BadRequest,
					title: "Invalid Product Data",
					detail: e.Message
				);
			}
		}

		[HttpDelete("{productID}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
		public IActionResult Delete([FromRoute] string productID)
		{
			return _service.Delete(productID) ? NoContent() : Problem(
				statusCode: StatusCodes.Status404NotFound,
				title: "Product Not Found!",
				detail: $"No product was found in ID {productID}"
			);
		}

		[HttpPut("{productID}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
		[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
		public ActionResult<ProductResponse> Update(
			[FromRoute] string productID, [FromBody] UpdateProductRequest request)
			{
				try
				{
					var existingProduct = _service.Update(productID, request);

					return existingProduct is null ? 
					Problem(statusCode: StatusCodes.Status404NotFound, title: "Product not found", detail: $"No product was found for ID {productID}.") : Ok(existingProduct);
				}
				catch (ArgumentException e)
				{
					return Problem(
						statusCode: StatusCodes.Status400BadRequest,
						title: "Invalid product data!",
						detail: e.Message);
				}
			}
	}
}