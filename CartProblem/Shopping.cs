﻿using System.Collections.Generic;
using System.Text;

namespace CartProblem
{
    class Shopping
    {
        private Cart _cart;
        private Admin _admin;
        private double totalDiscount;
        private double totalAmount;

        public Shopping()
        {
            _admin = new Admin();
            _cart = new Cart(_admin.GetProductsList());
            totalDiscount = 0;
            totalAmount = 0;
        }

        public void AddItem(string name, int quantity)
        {
            bool flag = false;

           foreach(var item in _admin.GetProductsList())
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


        public void RemoveItem(string name, int quantity)
        {
            bool flag = false; 

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

        public double CalculateTotalDiscount()
        { 
            var discountCalculation = new DiscountCalculation();
            foreach(var item in _cart.GetCartItemList())
            {
                int discountRate = item.Key.GetProductDiscount();
                double amount = item.Key.GetProductPrice() * item.Value;
                totalDiscount+= discountCalculation.GetDiscount(amount, discountRate);
            }

            return totalDiscount;
        }

        public double CalculateTotalAmount()
        {
            var amountCalculation = new AmountCalculation();
            return amountCalculation.GetFinalAmount(_admin.GetProductsList(), _cart.GetCartItemList());
            
        }

    }

}