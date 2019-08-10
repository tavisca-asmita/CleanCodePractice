using System.Collections.Generic;

namespace CartProblem
{
    public class Cart
    {
        private List<Product> _itemList;
        private Dictionary<Product, int> _cartItemList;
        
        public Cart(List<Product> itemList)
        {
            _cartItemList = new Dictionary<Product, int>();
            this._itemList = itemList; 
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
                        
        }

        public void RemoveItemFromCart(Product product, int quantity)
        {
          
            if (_cartItemList[product] - quantity == 0)
                _cartItemList.Remove(product);
            
            else
                _cartItemList[product] = _cartItemList[product] - quantity;            
            
        }

        public Dictionary<Product, int> GetCartItemList()
        {
            return _cartItemList;
        }
        
    }
}
