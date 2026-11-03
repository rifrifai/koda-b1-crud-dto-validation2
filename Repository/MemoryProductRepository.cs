using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;

namespace API.Repository;

public class MemoryProductRepository(MemoryProductCatalog catalog) : IProductRepository
{
    private readonly MemoryProductCatalog _catalog = catalog;

    public IReadOnlyList<Product> GetAllProducts() => _catalog.GetProducts();

    public Product? GetById(string productID) => _catalog.GetProduct(productID);

    public bool TryAdd(Product product) => _catalog.CreateProduct(product);

    public bool TryDelete(string productID) => _catalog.RemoveProduct(productID);

    public bool TryUpdate(Product product) => _catalog.UpdateProduct(product);
}