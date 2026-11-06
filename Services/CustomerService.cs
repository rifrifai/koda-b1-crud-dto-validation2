using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs.Customers;
using API.Models;
using API.Repository;

namespace API.Services;

public class CustomerService(ICustomerRepository repo) : ICustomerService
{
    private readonly ICustomerRepository _repo = repo;
    public async Task<CustomerResponse?> CreateAsync(CustomerRequest request, CancellationToken ct)
    {
        var customer = new Customer(request.CustomerId, request.Name, request.Email, request.Phone, request.Address);
        var created = await _repo.TryAddAsync(customer, ct);
        
        return created ? CustomerResponse.FromModel(customer) : null;
    }

    public Task<bool> DeleteAsync(int id, CancellationToken ct)
    {
        if (int.IsNegative(id)) return Task.FromResult(false);

        return _repo.TryDeleteAsync(id, ct);
    }

    public async Task<IReadOnlyList<CustomerResponse>> GetAllAsync(CancellationToken ct)
    {
        var customers = await _repo.GetAllAsync(ct);
        return customers.Select(CustomerResponse.FromModel).ToArray();
    }

    public async Task<CustomerResponse?> GetByIdAsync(int id, CancellationToken ct)
    {
        if (int.IsNegative(id)) return null;

        var customer = await _repo.GetByIdAsync(id, ct);
        return customer is null ? null : CustomerResponse.FromModel(customer);
    }

    public async Task<CustomerResponse?> UpdateAsync(int id, UpdateCustomerRequest request, CancellationToken ct)
    {
        var customer = new Customer(id, request.Name, request.Email, request.Phone, request.Adress);
        var updated = await _repo.TryUpdateAsync(customer, ct);

        return updated ? CustomerResponse.FromModel(customer) : null;
    }
}