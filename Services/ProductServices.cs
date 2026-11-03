using API.DTOs;
using API.Models;
using API.Repository;

namespace API.Services;

public sealed class ProductServices(IProductRepository repo) : IProductService
{
	private readonly IProductRepository _repo = repo;
	public ProductResponse? Create(ProductRequest request)
	{
		var product = new Product(request.ProductID, request.Name, request.Price, request.Stock);

		return _repo.TryAdd(product) ? ProductResponse.FromModel(product) : null;
	}

	public bool Delete(string productID) => _repo.TryDelete(productID);

	public ProductResponse? GetProduct(string productID)
	{
		var product =_repo.GetById(productID);

		return product is null ? null : ProductResponse.FromModel(product);
	}

	public IReadOnlyList<ProductResponse> GetProducts() => _repo.GetAllProducts().Select(ProductResponse.FromModel).ToArray();

	public ProductResponse? Update(string productID, UpdateProductRequest request)
	{
		var product = new Product(productID, request.Name, request.Price, request.Stock);
		
		return _repo.TryUpdate(product) ? ProductResponse.FromModel(product) : null;
	}
}