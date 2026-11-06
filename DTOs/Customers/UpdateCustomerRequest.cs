using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs.Customers;
public record class UpdateCustomerRequest(
    [Required(ErrorMessage = "Nama customer wajib diisi.")]
    [StringLength(120, ErrorMessage = "Nama customer maksimal 120 karakter.")] string Name,

    [Required(ErrorMessage = "Email wajib diisi.")]
    [EmailAddress(ErrorMessage = "Invalid input email")] string Email,

    [Required(ErrorMessage = "Phone wajib diisi.")]
    [StringLength(13, ErrorMessage = "Phone tidak boleh lebih dari 13 karakter.")] string Phone,

    [Required, StringLength(120)] string Adress
);