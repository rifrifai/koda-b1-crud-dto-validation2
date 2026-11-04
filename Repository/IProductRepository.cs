using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository;
public interface IProductRepository
{
	Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken ck);
	Task<Product?> GetByCodeAsync(string productCode, CancellationToken ck);
	Task<bool> TryAddAsync(Product product, CancellationToken ck);
	Task<bool> TryUpdateAsync(Product product, CancellationToken ck);
	Task<bool> TryDeleteAsync(string productCode, CancellationToken ck);
}