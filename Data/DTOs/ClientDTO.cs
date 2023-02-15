namespace BankApi.Data.DTOs;

public class ClientDTO{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }
}