using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheNekoPizzaria.Models;

namespace TheNekoPizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<Models.PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new Models.PizzasModel(){ImageTitle="Margerita", 
            PizzaName= "Margerita", 
            BasePrice=2, 
            TomatoSauce=true, 
            Cheese=true, 
            FinalPrice=3},

            new Models.PizzasModel(){ImageTitle="Bolognese",
            PizzaName= "Bolognese",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Beef=true,
            FinalPrice=4},

            new Models.PizzasModel(){ImageTitle="Carbonara",
            PizzaName= "Carbonara",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Ham=true,
            FinalPrice=4},

            new Models.PizzasModel(){ImageTitle="Hawaiian",
            PizzaName= "Hawaiian",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Ham=true,
            Pineapple=true,
            FinalPrice=3},

            new Models.PizzasModel(){ImageTitle="MeatFeast",
            PizzaName= "MeatFeast",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Beef=true,
            Ham=true,
            Peperoni=true,
            FinalPrice=7},

            new Models.PizzasModel(){ImageTitle="Mushroom",
            PizzaName= "Mushroom",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Mushroom=true,
            FinalPrice=3},

            new Models.PizzasModel(){ImageTitle="Pepperoni",
            PizzaName= "Pepperoni",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Peperoni=true,
            FinalPrice=4},

            new Models.PizzasModel(){ImageTitle="Seafood",
            PizzaName= "Seafood",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Tuna=true,
            Shripm=true,
            FinalPrice=5},

            new Models.PizzasModel(){ImageTitle="Vegetarian",
            PizzaName= "Vegetarian",
            BasePrice=2,
            TomatoSauce=true,
            Cheese=true,
            Mushroom=true,
            Onion=true,
            FinalPrice=3},
        };
    public void OnGet()
        {
        }
    }
}
