using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Domain
{
    public class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategyFor(int type)//(CustomerType customerType)
        {
            switch(type)//(customerType)
            {
                case 0://CustomerType.Trade:
                    return new TradeDiscountStrategy();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}