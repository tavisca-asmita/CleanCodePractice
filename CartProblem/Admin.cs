using System.Collections.Generic;

namespace CartProblem
{
    public class Admin
    {
        private static List<Product> _itemList;
        Product product;

        public Admin()
        {
            product = new Product();
            _itemList = new List<Product>();
            AddProductToList();
        }
        public void AddProductToList()
        {   
            
            product.AddProduct("Milk", "Dairy", 50);
            _itemList.Add(product);
            product.AddProduct("Eggs", "Poultry", 24.50);
            _itemList.Add(product);
            product.AddProduct("Meat", "Poultry", 100);
            _itemList.Add(product);
            product.AddProduct("Tomato", "Vegetables", 30);
            _itemList.Add(product);
            product.AddProduct("Cabbage", "Vegetables", 26);
            _itemList.Add(product);
            product.AddProduct("Cheese", "Dairy", 55);
            _itemList.Add(product);
            product.AddProduct("Pencils", "Stationary", 12.50);
            _itemList.Add(product);
            product.AddProduct("Notebook", "Stationary", 20);
            _itemList.Add(product);
        }

        public List<Product> GetProductsList()
        {
            return _itemList;
        }
    }
}

