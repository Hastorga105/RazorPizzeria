using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.wwwroot.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
		//This is my fake database
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Mushroom", 
                PizzaName="Mushroom", 
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4   
            },
			new PizzasModel()
			{
				ImageTitle="Bolognese",
				PizzaName="Bolognese",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				FinalPrice=4
			},
			new PizzasModel()
			{
				ImageTitle="Hawaiian",
				PizzaName="Hawaiian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				FinalPrice=4
			},
			new PizzasModel()
			{
				ImageTitle="Pepperoni",
				PizzaName="Pepperoni",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				FinalPrice=4
			},
		};
        public void OnGet()
        {

        }
    }
}
