using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Promotions
{
    public class PromotionRulesType1
    {
        public PromotionRulesType1()
        {

        }
        public PromotionRulesType1(char SKU , int noOfItems, int price)
        {
            this.SKU = SKU;
            this.noOfItems = noOfItems;
            this.price = price;
        }
        public char SKU { get; set; }
        public int noOfItems { get; set; }
        public int price { get; set; }

        
    }

   
}
