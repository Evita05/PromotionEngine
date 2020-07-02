using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Carts
{
    public class CartItem
    {
        public SKU skuItem { get; set; }
        public int noOfItems { get; set; }
        public float skuTotal { get; set; }


        public CartItem(SKU skuItem , int noOfItems )
        {
            this.skuItem = skuItem;
            this.noOfItems = noOfItems;
            this.skuTotal = skuItem.skuPrice * noOfItems;
        }

      
    }

    
}
