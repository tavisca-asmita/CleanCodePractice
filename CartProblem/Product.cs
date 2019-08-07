namespace CartProblem
{
    public class Product
    {
        public string Name { get; private set; }

        public double Price { get; private set; }

        public string Category { get; private set; }

        public void AddProduct(string productName, string productCategory, double productPrice)
        {
            Name = productName;
            Category = productCategory;
            Price = productPrice;
        }
    }
}
