using DynamicTechShop.Models;
using System.Net.Http.Headers;

namespace DynamicTechShop.Database
{
    public static class ShoppingCartList
    {
        public static List<ProductModel> shoppingCart { get; set; } = new();
    }
}
