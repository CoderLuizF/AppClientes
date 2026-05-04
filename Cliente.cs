namespace Cadastro;

public class Cliente
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public decimal Discount { get; set; }
}