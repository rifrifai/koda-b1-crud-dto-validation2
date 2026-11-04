// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.DTOs;
// using API.Models;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Data;
// public sealed class MemoryProductCatalog
// {
// 	private readonly Lock _sync = new();
// 	private readonly List<Product> _products = [];
// 	public IReadOnlyList<Product> GetProducts()
// 	{
// 		lock(_sync)
// 		{
// 			return [.._products];
// 		}
// 	}
// 	public Product? GetProduct(string productID)
// 	{
// 		lock(_sync)
// 		{
// 			return _products.FirstOrDefault(p => string.Equals(p.ProductID, productID.Trim(), StringComparison.OrdinalIgnoreCase));
// 		}
// 	} 

// 	public bool CreateProduct(Product product)
// 	{
// 		lock(_sync)
// 		{
// 			if (_products.Any(p => p.ProductID == product.ProductID))
// 			{
// 				return false;
// 			}
// 			_products.Add(product);
// 			return true;
// 		}
// 	}

// 	public bool RemoveProduct (string productID)
// 	{
// 		lock(_sync)
// 		{
// 			var index = _products.FindIndex(p => string.Equals(p.ProductID, productID.Trim(), StringComparison.OrdinalIgnoreCase));

// 			if (index == -1) return false;
			
// 			_products.RemoveAt(index);
// 			return true;
// 		}
// 	}

// 	public bool UpdateProduct(Product updatedProduct)
// 	{
// 		lock(_sync)
// 		{
// 			var index = _products.FindIndex(p => string.Equals(p.ProductID, updatedProduct.ProductID.Trim(), StringComparison.OrdinalIgnoreCase));

// 			if (index == -1) return false;

// 			_products[index] = updatedProduct;
// 			return true;
// 		}
// 	}
// }