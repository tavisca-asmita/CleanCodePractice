using System.Collections.Generic;

namespace CartProblem
{
    public class Admin
    {
        private List<Product> _itemList;        

        public Admin()
        {            
            _itemList = new List<Product>();
            AddProductToList();
        }
        public void AddProductToList()
        {   
                        
            _itemList.Add(new Product().AddProduct("Milk", "Dairy", 50));           
            _itemList.Add(new Product().AddProduct("Eggs", "Poultry", 24.50));            
            _itemList.Add(new Product().AddProduct("Meat", "Poultry", 100));            
            _itemList.Add(new Product().AddProduct("Tomato", "Vegetables", 30));            
            _itemList.Add(new Product().AddProduct("Cabbage", "Vegetables", 26));            
            _itemList.Add(new Product().AddProduct("Cheese", "Dairy", 55));          
            _itemList.Add(new Product().AddProduct("Pencils", "Stationary", 12.50));            
            _itemList.Add(new Product().AddProduct("Notebook", "Stationary", 20));
        }

        public List<Product> GetProductsList()
        {
            return _itemList;
        }
    }
}

