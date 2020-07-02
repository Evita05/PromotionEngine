using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenge.Carts;

namespace CodingChallenge.Promotions
{
    public class PromotionType2 : IPromotion
    {
        public List<PromotionalRulesType2> rule { get; set; }
        
        public PromotionType2()
        {
            this.rule = new List<PromotionalRulesType2>();
            
        }
        public int setPromotion(Cart cart)
        {
            int cNoOfItems = 0, dNoOfItems = 0, diff = 0, pairs = 0;
            CartItem C = null, D = null;
            foreach (CartItem cobj in cart.getCart())
            {
                foreach (PromotionalRulesType2 p in rule)
                {
                    if (cobj.skuItem.sku == p.sku1 )
                    {
                        cNoOfItems = cobj.noOfItems;
                        C = cobj;
                    }
                    if (cobj.skuItem.sku == p.sku2)
                    {
                        dNoOfItems = cobj.noOfItems;
                        D = cobj;
                    }
                }

            }

            if (C != null && D != null)
            {
                if (cNoOfItems >= dNoOfItems)
                {
                    diff = cNoOfItems - dNoOfItems;
                    pairs = (cNoOfItems - diff);
                    C.skuTotal = pairs * 30 + diff * C.skuItem.skuPrice;
                    D.skuTotal = 0;
                }
                else
                {
                    diff = dNoOfItems - cNoOfItems;
                    pairs = (dNoOfItems - diff);
                    D.skuTotal = pairs * 30 + diff * D.skuItem.skuPrice;
                    C.skuTotal = 0;

                }
            }



            return 1;
        }
        public void setPromotionRules(char sku1, char sku2, int price)
        {
            PromotionalRulesType2 pi2 = new PromotionalRulesType2(sku1, sku2, price);
            rule.Add(pi2);
        }
    }
}

