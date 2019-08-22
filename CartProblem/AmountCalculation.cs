using System.Collections.Generic;

namespace CartProblem
{
    public class AmountCalculation
    {
        private double _amount;
        public AmountCalculation()
        {
            _amount = 0;
        }

        public double GetFinalAmount(Dictionary<Product, int> cartItemList)
        {
            _amount = 0;
            foreach (var product in cartItemList)
            {
                var discountCalculation = new DiscountCalculation();
                _amount += discountCalculation.GetDiscountedAmount((product.Value * product.Key.GetProductPrice()), (product.Key.GetProductDiscount()));
                
            }

            return _amount;
        }
                
    }
}
