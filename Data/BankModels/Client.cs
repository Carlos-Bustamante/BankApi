using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BankApi.Data.BankModels;

public partial class Client
{
    public int Id { get; set; }

    [MaxLength(20, ErrorMessage ="El nombre no puede superar los 200 caracteres.")]
    public string Name { get; set; } = null!;

    [MaxLength(40, ErrorMessage = "El numero debe ser menor a 40.")]
    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime RegDate { get; set; }

    [JsonIgnore]
    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
