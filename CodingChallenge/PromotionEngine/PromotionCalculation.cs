using CodingChallenge.Carts;
using CodingChallenge.Promotions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.PromotionEngine
{
    public sealed class PromotionCalculation
    {
        private PromotionCalculation()
        {

        }
        private static PromotionCalculation instance = null;
        public static PromotionCalculation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PromotionCalculation();
                }
                return instance;
            }
        }
        List<IPromotion> promotions = new List<IPromotion>();

        public void AddPromotionToList(IPromotion prom)
        {
            promotions.Add(prom);

        }

        public void applyPromotions(Cart c)
        {
            int flag = 0;
            foreach (var p in promotions)
            {
                flag = p.setPromotion(c);
                if (flag == 1)
                {
                    // one promotion applied return
                    continue;
                }
            }
        }

        public IPromotion createInstanceForPromotionType(int type)
        {
            if (type == 1)
                return new PromotionType1();
            else if (type == 2)
                return new PromotionType2();
            else
                return null;

        }

    }
}
