using eCinemas.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace eCinemas.Data.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        //Get the number of items in the shopping cart 
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);



        }
    }
}
