namespace CartProblem
{
    public class DiscountCalculation
    {
        
        public double GetDiscount(double amount, int discountRate)
        {
            return (amount * (discountRate / 100));
        }

        public double GetDiscountedAmount(double amount, int discountRate)
        {
            return (amount - (amount * (discountRate / 100)));
        }
        
    }
}
