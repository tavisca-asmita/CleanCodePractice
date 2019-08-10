namespace CartProblem
{
    public class Product
    {
        ICategory category;
        string name;
        double price;
        int discount;

        public Product()
        {
            name = "";
            price = 0;
            discount = 0;
        }
        
        public void AddProduct(string name, string category, double price)
        {
            this.name = name;
            this.price = price;
            
            if (category.Contains("Dairy"))
            {
                this.category = new Dairy();
                discount = this.category.GetCategoryDiscount();
            }

            else if (category.Contains("Groceries"))
            {
                this.category = new Groceries();
                discount = this.category.GetCategoryDiscount();
            }

            else if (category.Contains("PersonalCare"))
            {
                this.category = new PersonalCare();
                discount = this.category.GetCategoryDiscount();
            }

            else if (category.Contains("Poultry"))
            {
                this.category = new Poultry();
                discount = this.category.GetCategoryDiscount();
            }

            else if (category.Contains("Stationary"))
            {
                this.category = new Stationary();
                discount = this.category.GetCategoryDiscount();
            }

            else if (category.Contains("Vegetables"))
            {
                this.category = new Vegetables();
                discount = this.category.GetCategoryDiscount();
            }

            else
            {
                this.category = new Miscellaneous();
                discount = this.category.GetCategoryDiscount();
            }
        }

        public string GetProductName()
        {
            return name;
        }

        public int GetProductDiscount()
        {            
            return discount;
        }

        public double GetProductPrice()
        {
            return price;
        }
    }
}
