using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
	public sealed class Product(string productCode, string name, decimal price, int stock, string category)
	{
		public Guid ProductID { get; }
		public string ProductCode { get; } = productCode;
		public string Name { get; } = name;
		public decimal Price { get; } = price;
		public int Stock { get; } = stock;
		public string Category { get; } = category;
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(7);
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(7);

		public string GetInfo()
		{
			return $"ID: {ProductID}, Name: {Name}, Price: {Price}, Stock: {Stock}, Category: {Category}";
		}
	}
}