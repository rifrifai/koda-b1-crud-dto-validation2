using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository;
public interface IProductRepository
{
    IReadOnlyList<Product> GetAllProducts();
    Product? GetById(string productID);
    bool TryAdd(Product product);
    bool TryUpdate(Product product);
    bool TryDelete(string productID);
}