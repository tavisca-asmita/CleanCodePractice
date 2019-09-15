using System.Collections.Generic;
using System.Text;

namespace CartProblem
{
    public class Shopping
    {
        private Cart _cart;
        private Admin _admin;
        private CartCostCalculator _amountCalculation;
        private DiscountCalculator _discountCalculation;
        private double totalDiscount;
        
        public Shopping()
        {
            _amountCalculation = new CartCostCalculator();
            _admin = new Admin();
            _cart = new Cart(_admin.GetProductsList());
            _discountCalculation = new DiscountCalculator();
            totalDiscount = 0;
        }

        public void AddItem(string name, int quantity)
        {
            bool flag = false;

            if (quantity < 1)
                throw new NegativeQuantityException();
            else
            {
                foreach (var item in _admin.GetProductsList())
                {
                    if (item.GetProductName().Contains(name))
                    {
                        _cart.AddItemToCart(item, quantity);
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                    new ItemNotFoundException();

            }            
        }


        public void RemoveItem(string name, int quantity)
        {
            bool flag = false;

            if (quantity < 1)
                throw new NegativeQuantityException();

            else
            {
                foreach (var item in _cart.GetCartItemList())
                {
                    if (item.Key.GetProductName().Contains(name))
                    {
                        _cart.RemoveItemFromCart(item.Key, quantity);
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                    new ItemNotFoundException();
            }            
        }

        public double CalculateTotalDiscount()
        { 
            foreach(var item in _cart.GetCartItemList())
            {
                int discountRate = item.Key.GetProductDiscount();
                double amount = item.Key.GetProductPrice() * item.Value;
                totalDiscount+= _discountCalculation.GetDiscount(amount, discountRate);
            }

            return totalDiscount;
        }

        public double CalculateTotalAmount()
        {
            return _amountCalculation.GetFinalAmount(_cart.GetCartItemList());
            
        }
                
    }

}
