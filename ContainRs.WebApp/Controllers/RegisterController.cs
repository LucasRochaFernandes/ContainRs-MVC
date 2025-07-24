using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContainRs.WebApp.Controllers;

public class RegisterController : Controller
{
    private readonly AppDbContext context;

    public RegisterController(AppDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Success() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateAsync(RegisterViewModel form)
    {
        if (!ModelState.IsValid) return View("Index", form);

        var cliente = new User(form.Name, form.Email, form.CPF)
        {
            PhoneNumber = form.PhoneNumber,
            CEP = form.CEP,
            Street = form.Street,
            HouseNumber = form.HouseNumber,
            AddressComplement = form.AddressComplement,
            Neighborhood = form.Neighborhood,
            City = form.City,
            State = form.State
        };
        context.Users.Add(cliente);
        await context.SaveChangesAsync();

        return RedirectToAction("Success");
    }
}
