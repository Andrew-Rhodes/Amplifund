using Microsoft.AspNetCore.Mvc;
using RhodesShoppe.Models;

namespace RhodesShoppe.Controllers
{
    public class RepairController : Controller
    {
        private readonly HttpClient _httpClient;

        public RepairController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var repairs = await _httpClient.GetFromJsonAsync<List<RhodesShoppe.Api.Models.GuitarRepair>>("https://localhost:7067/api/repairs");
            return View(repairs);
        }
    }


}
