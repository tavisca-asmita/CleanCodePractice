using System.Collections.Generic;

namespace CartProblem
{
    public class CartCostCalculator
    {
        
        public double GetFinalAmount(Dictionary<Product, int> cartItemList)
        {
            double _amount = 0;
            foreach (var product in cartItemList)
            {
                var discountCalculation = new DiscountCalculator();
                _amount += discountCalculation.GetDiscountedAmount((product.Value * product.Key.GetProductPrice()), (product.Key.GetProductDiscount()));
                
            }

            return _amount;
        }
                
    }
}
