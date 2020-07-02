using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Promotions
{
    public class PromotionalRulesType2
    {
        public PromotionalRulesType2()
        {

        }
        public PromotionalRulesType2(char sku1,char sku2, int price)
        {
            this.sku1 = sku1;
            this.sku2 = sku2;
            this.price = price;

        }
        public char sku1 { get; set; }

        public char sku2 { get; set; }
        
        public int price { get; set; }
        

        
    }

   
}
