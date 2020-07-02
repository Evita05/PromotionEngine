using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge
{
    public class SKU
    {
        public char sku { get; set; }

        public float skuPrice { get; set; }
       
        public SKU (char sku , float skuPrice)
        {
            this.sku = sku;
            this.skuPrice = skuPrice;

        }

        
    }
}
