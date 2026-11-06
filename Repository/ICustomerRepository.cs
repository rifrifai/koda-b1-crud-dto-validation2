using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository;
public interface ICustomerRepository
{
    Task<IReadOnlyList<Customer>> GetAllAsync(CancellationToken ct);
	Task<Customer?> GetByIdAsync(int id, CancellationToken ct);
	Task<bool> TryAddAsync(Customer customer, CancellationToken ct);
	Task<bool> TryUpdateAsync(Customer customer, CancellationToken ct);
	Task<bool> TryDeleteAsync(int id, CancellationToken ct);
}