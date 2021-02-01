using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ECommerce.Entity
{
    public class Cart
    {
        public String Id { get; set; }
        public List<CartItem> CartItems { get; set; }

        public Cart()
        {
            CartItems = new List<CartItem>();
        }



        public void AddProduct(Product product, int quantity = 1)
        {
            CartItem cartItem = GetCartItem(product.Id);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                CartItems.Add(new CartItem { Product = product, Quantity = quantity, Id = product.Id });
            }
        }

        public void RemoveCartItemByProductId(int productId)
        {
            CartItem cartItem = GetCartItem(productId);
            CartItems.Remove(cartItem);
        }

        private CartItem GetCartItem(int productId)
        {
            return CartItems.FirstOrDefault(cartItem => cartItem.Product.Id == productId);
        }

        public double CalculateTotalPrice()
        {
            double result = 0;

            foreach(CartItem cartItem in CartItems)
            {
                result += cartItem.Product.UnitPrice * cartItem.Quantity;
            }

            return result;
        }

    }
}
