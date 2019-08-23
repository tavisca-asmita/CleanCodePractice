using System;
using CartProblem;
using Xunit;

namespace CleanCodePracticesTestProject
{    

    public class CartTest
    {
        [Fact]
        public void CalculateAmountOfProductsTest()
        {
            Admin admin = new Admin();
            Assert.Equal(8, admin.GetProductsList().Count);                                 
            
        }

        [Fact]
        public void CalculateAmountOfCartTest()
        {
            Shopping shopping = new Shopping();
            shopping.AddItem("Milk", 1);
            shopping.AddItem("Eggs", 2);
            Assert.Equal(96.02, (Math.Round(shopping.CalculateTotalAmount(),2)));
            
        }
    }
}
