using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTOs.Customers;
public record class CustomerResponse(int Id, string Name, string Email, string Phone, string Address)
{
	public List<ProductResponse> Products { get; init; } = [];
	public static CustomerResponse FromModel(Customer customer) => new (customer.Id, customer.Name, customer.Email, customer.Phone, customer.Address)
	{
		Products = customer.Products.Select(p => ProductResponse.FromModel(p)).ToList(),
	};
}