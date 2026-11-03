using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Models;

namespace API.Services;
public interface IProductService
{
    IReadOnlyList<ProductResponse> GetProducts();
    ProductResponse? GetProduct(string productID);
    ProductResponse? Create(ProductRequest request);
    ProductResponse? Update(string productID, UpdateProductRequest request);
    bool Delete(string productID);
}