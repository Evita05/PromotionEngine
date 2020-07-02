using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Carts
{
    public class Cart
    {
        public List<CartItem> cartItems = new List<CartItem>();
        public float cartTotal = 0.0f;

        public void EmptyCart()
        {
            cartItems = null;
        }

        public void AddItemToCart(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public float CartTotal()
        {
            if(cartItems != null)
            {
                cartTotal = 0.0f;
                foreach(var items in cartItems)
                {
                    cartTotal = cartTotal + items.skuTotal;
                }
            }
            return cartTotal;
        }
        public List<CartItem> getCart()
        {
            return cartItems;
        }
    }
}
