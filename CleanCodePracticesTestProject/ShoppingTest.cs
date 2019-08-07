using System;
using CartProblem;
using Xunit;

namespace CleanCodePracticesTestProject
{    

    public class CartTest
    {
        [Fact]
        public void CalculateAmountOfCartTest()
        {
            Admin admin = new Admin();
            Assert.Equal(8, admin.GetProductsList().Count);                                 
            
        }
    }
}
