using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Carts;

namespace CodingChallenge.Promotions
{
    public class PromotionType1 : IPromotion
    {

        public List<PromotionRulesType1> rule1 { get; set; }
        public PromotionType1()
        {
            this.rule1 = new List<PromotionRulesType1>();
        }

        
        public int setPromotion(Cart cart)
        {
            int flag = 0;
            float cart_item_total = 0;
            int multiplier = 0;
            int remainder = 0;

            foreach (CartItem cobj in cart.getCart())
            {
                foreach (PromotionRulesType1 p in rule1)
                {
                    if (cobj.skuItem.sku == p.SKU && cobj.noOfItems >= p.noOfItems)
                    {
                        cobj.skuTotal = 0;
                        multiplier = cobj.noOfItems / p.noOfItems;
                        remainder = cobj.noOfItems % p.noOfItems;
                        cart_item_total = p.price * multiplier + remainder * cobj.skuItem.skuPrice;
                        cobj.skuTotal = cart_item_total;
                        flag = 1;
                    }
                }

            }

            return flag;
        }

        public void setPromotionRules(char sku, int noOfItem, int price)
        {
            PromotionRulesType1 pi1 = new PromotionRulesType1(sku, noOfItem, price);
            rule1.Add(pi1);
        }
       


    }
}
