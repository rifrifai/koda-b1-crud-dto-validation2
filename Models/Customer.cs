using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models;
public class Customer(int id, string name, string email, string phone, string address)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Phone { get; set; } = phone;
    public string Address { get; set; } = address;
    
    public List<Product> Products { get; set; } = [];
}