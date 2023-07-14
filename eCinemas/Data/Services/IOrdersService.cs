using eCinemas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCinemas.Data.Services
{
    public interface IOrdersService
    {
        //Add orders to database
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);

        //Get orders from database
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
