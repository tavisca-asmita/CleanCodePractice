using System.Collections.Generic;

namespace CartProblem
{
    public class Cart
    {
        private List<Product> _itemList;
        private Dictionary<Product, int> _cartItemList;
        private double _amount;


        public Cart(List<Product> itemList)
        {
            _cartItemList = new Dictionary<Product, int>();
            _itemList = itemList;           
            _amount = 0;
        }

        public void AddItemToCart(Product product, int quantity)
        {
            if (_cartItemList.ContainsKey(product))
            {
                int updatedquantity = _cartItemList[product] + quantity;
                _cartItemList[product] = updatedquantity;
            }

            else
                _cartItemList.Add(product, quantity);            

            // Calculating total amount after every change
            CalculateTotalAmount();
        }

        public void RemoveItemFromCart(Product product, int quantity)
        {
          
            if (_cartItemList[product] - quantity == 0)
                _cartItemList.Remove(product);

            
            else
                _cartItemList[product] = _cartItemList[product] - quantity;

            
            // Calculating total amount after every change
            CalculateTotalAmount();
        }

        // Calculate total amount
        public void CalculateTotalAmount()
        {
            foreach(var product in _cartItemList)
            {
                if (_itemList.Contains(product.Key))
                {
                    _amount += product.Value * product.Key.Price;
                }
            }         

        }

        public double GetAmount()
        {
            return _amount;
        }
    }
}
