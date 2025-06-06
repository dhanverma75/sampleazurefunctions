﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Order
    {
        public string id { get; set; }
        public DateTime orderDate { get; set; }
        public double total { get; set; }
        public int priority { get; set; }
        public List<OrderItem> items { get; set; }

        public Order()
        {
            var rand = new Random();
            priority = rand.Next(3) + 1;
        }
    }

    public class OrderItem
    {
        public String name { get; set; }
        public int id { get; set; }
        public double price { get; set; }
    }
}