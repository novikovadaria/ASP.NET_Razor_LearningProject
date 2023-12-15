using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


using TheNekoPizzaria.Models;

namespace TheNekoPizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()

        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 3;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 3;
            if (Pizza.Tuna) PizzaPrice += 2;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
