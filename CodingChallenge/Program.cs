using CodingChallenge.Carts;
using CodingChallenge.PromotionEngine;
using CodingChallenge.Promotions;
using System;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //Inputs of SKU
            Cart cart = new Cart();
            SKU skus = new SKU('A', 50);
            SKU skus1 = new SKU('B', 30);
            SKU skus2 = new SKU('C', 20);
            SKU skus3 = new SKU('D', 15);

            //Add items into the cart and calculate original price of each sku
            cart.AddItemToCart(new CartItem(skus, 3));
            cart.AddItemToCart(new CartItem(skus1, 5));
            cart.AddItemToCart(new CartItem(skus2, 1));
            cart.AddItemToCart(new CartItem(skus3, 1));

            PromotionCalculation e = PromotionCalculation.Instance;
            //Assigning 1 for PromotionType1
            PromotionType1 a1= (PromotionType1)e.createInstanceForPromotionType(1);

            a1.setPromotionRules('A', 3, 130);
            a1.setPromotionRules('B', 2, 45);
            e.AddPromotionToList(a1);

            //Assigning 2 for PromotionType2
            PromotionType2 a2 = (PromotionType2)e.createInstanceForPromotionType(2);
            a2.setPromotionRules('C', 'D', 30);
            e.AddPromotionToList(a2);

            float total = 0.0f;
            e.applyPromotions(cart);
            total = cart.CartTotal();
            Console.WriteLine("Cart Total :: " + total);
            Console.ReadLine();
        }
    }
}
