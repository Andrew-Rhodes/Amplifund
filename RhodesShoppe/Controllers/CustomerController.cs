using Microsoft.AspNetCore.Mvc;

namespace RhodesShoppe.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomerController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _httpClient.GetFromJsonAsync<List<RhodesShoppe.Api.Models.Customer>>("https://localhost:7067/api/customers");
            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View("AddCustomer");
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(RhodesShoppe.Models.Customer customer)
        {
            //I just need this here to make it work for now. 
            //I would flesh out the form some more to add the repair to the customer
            customer.Repairs = new List<RhodesShoppe.Models.GuitarRepair>();

            if (ModelState.IsValid)
            {
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7067/api/customers", customer);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while adding the customer.");
                }
            }

            return View(customer);
        }
    }
}
