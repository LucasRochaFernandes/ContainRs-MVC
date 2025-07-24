using System.ComponentModel.DataAnnotations;

namespace ContainRs.WebApp.Models;

public class RegisterViewModel
{
    [Display(Name = "Nome (*)", Prompt = "Digite seu nome completo.")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string Name { get; set; }

    [Display(Name = "E-mail (*)", Prompt = "Digite seu melhor e-mail.")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail inválido.")]
    public string Email { get; set; }

    [Display(Name = "CPF (*)", Prompt = "000.000.000-00")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string CPF { get; set; }
    [Display(Prompt = "(00) 00000-0000")]
    public string? PhoneNumber { get; set; }
    [Display(Prompt = "00.000-000")]
    public string? CEP { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; }
    public string? AddressComplement { get; set; }
    public string? Neighborhood { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
}
