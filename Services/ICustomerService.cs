using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs.Customers;

namespace API.Services;
public interface ICustomerService
{
    Task<IReadOnlyList<CustomerResponse>> GetAllAsync(CancellationToken ct);
    Task<CustomerResponse?> GetByIdAsync(int id, CancellationToken ct);
    Task<CustomerResponse?> CreateAsync(CustomerRequest request, CancellationToken ct);
    Task<CustomerResponse?> UpdateAsync(int id, UpdateCustomerRequest request, CancellationToken ct);
    Task<bool> DeleteAsync(int id, CancellationToken ct);
}