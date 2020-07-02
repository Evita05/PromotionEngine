using CodingChallenge;
using CodingChallenge.Carts;
using CodingChallenge.PromotionEngine;
using CodingChallenge.Promotions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CodingChallengeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float expected = 280;
            float actual = 0;
           

            Cart cart = new Cart();
            SKU skus = new SKU('A', 50);
            SKU skus1 = new SKU('B', 30);
            SKU skus2 = new SKU('C', 20);
            SKU skus3 = new SKU('D', 15);

           
            cart.AddItemToCart(new CartItem(skus, 3));
            cart.AddItemToCart(new CartItem(skus1, 5));
            cart.AddItemToCart(new CartItem(skus2, 1));
            cart.AddItemToCart(new CartItem(skus3, 1));

            PromotionCalculation e = PromotionCalculation.Instance;
            PromotionType1 a1 = (PromotionType1)e.createInstanceForPromotionType(1);

            a1.setPromotionRules('A', 3, 130);
            a1.setPromotionRules('B', 2, 45);
            e.AddPromotionToList(a1);

            PromotionType2 a2 = (PromotionType2)e.createInstanceForPromotionType(2);
            a2.setPromotionRules('C', 'D', 30);
            e.AddPromotionToList(a2);

 
            e.applyPromotions(cart);
            actual = cart.CartTotal();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            float expected = 370;
            float actual = 0;


            Cart cart = new Cart();
            SKU skus = new SKU('A', 50);
            SKU skus1 = new SKU('B', 30);
            SKU skus2 = new SKU('C', 20);
            SKU skus3 = new SKU('D', 15);


            cart.AddItemToCart(new CartItem(skus, 5));
            cart.AddItemToCart(new CartItem(skus1, 5));
            cart.AddItemToCart(new CartItem(skus2, 1));
            

            PromotionCalculation e = PromotionCalculation.Instance;
            PromotionType1 a1 = (PromotionType1)e.createInstanceForPromotionType(1);

            a1.setPromotionRules('A', 3, 130);
            a1.setPromotionRules('B', 2, 45);
            e.AddPromotionToList(a1);

            PromotionType2 a2 = (PromotionType2)e.createInstanceForPromotionType(2);
            a2.setPromotionRules('C', 'D', 30);
            e.AddPromotionToList(a2);


            e.applyPromotions(cart);
            actual = cart.CartTotal();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            float expected = 100;
            float actual = 0;


            Cart cart = new Cart();
            SKU skus = new SKU('A', 50);
            SKU skus1 = new SKU('B', 30);
            SKU skus2 = new SKU('C', 20);
            SKU skus3 = new SKU('D', 15);


            cart.AddItemToCart(new CartItem(skus, 1));
            cart.AddItemToCart(new CartItem(skus1, 1));
            cart.AddItemToCart(new CartItem(skus2, 1));


            PromotionCalculation e = PromotionCalculation.Instance;
            PromotionType1 a1 = (PromotionType1)e.createInstanceForPromotionType(1);

            a1.setPromotionRules('A', 3, 130);
            a1.setPromotionRules('B', 2, 45);
            e.AddPromotionToList(a1);

            PromotionType2 a2 = (PromotionType2)e.createInstanceForPromotionType(2);
            a2.setPromotionRules('C', 'D', 30);
            e.AddPromotionToList(a2);


            e.applyPromotions(cart);
            actual = cart.CartTotal();
            Assert.AreEqual(expected, actual);

        }
    }
}
