using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Domain
{
    public class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo (decimal OriginalSalePrice)
        {
            decimal price = OriginalSalePrice * 0.95M;
            return price;
        }
    }
}