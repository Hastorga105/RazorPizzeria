using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPizzeria.wwwroot.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] //Bind our pizza model to our custom pizza model so we can create pizza from custom pizza cshtml 
        public PizzasModel Pizza { get; set; }//Llamar al modelo
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
			if (Pizza.Cheese) PizzaPrice += 1;
			if (Pizza.Peperoni) PizzaPrice += 1;
			if (Pizza.Mushroom) PizzaPrice += 1;
			if (Pizza.Tuna) PizzaPrice += 1;
			if (Pizza.Pineapple) PizzaPrice += 1;
			if (Pizza.Ham) PizzaPrice += 1;
			if (Pizza.Beef) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice } );//After post go to checkout with our pizza name and price

		}
    }
}
