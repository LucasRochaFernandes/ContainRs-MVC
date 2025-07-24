using ContainRs.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContainRs.WebApp.Controllers;
public class CepController : Controller
{
    private readonly IViaCepService _cepService;

    public CepController(IViaCepService cepService)
    {
        _cepService = cepService;
    }

    public async Task<IActionResult> Consult(string cep)
    {
        var response = await _cepService.ConsultAsync(cep);

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            return Json(new { Error = "CEP not found" });
        }

        return Json(new
        {
            CEP = response.Content!.CEP,
            Street = response.Content.Logradouro,
            Neighborhood = response.Content.Bairro,
            City = response.Content.Localidade,
            State = response.Content.UF
        });
    }
}
