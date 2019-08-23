namespace CartProblem
{
    public class DiscountCalculator
    {
        
        public double GetDiscount(double amount, int discountRate)
        {            
            return amount * ((double)(discountRate) / 100);
        }

        public double GetDiscountedAmount(double amount, int discountRate)
        {
            double amt = amount - (amount * ((double) (discountRate) / 100));
            return amt;
        }
        
    }
}
