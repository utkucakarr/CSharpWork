﻿using System;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;

        public string ProductName { get; set; }

        public int Stock
        {
            get 
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value <= 15 && StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Stock {0} amount : {1}",ProductName, Stock);
        }
    }
}
