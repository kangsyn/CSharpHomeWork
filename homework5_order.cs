using System;
using System.Collections.Generic;
using System.Linq;

namespace number_one
{
    class Order
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public int PriceSum { get; set; }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order(int OrderID, string Customer)
        {
            this.OrderID = OrderID;
            this.Customer = Customer;
        }
        public void Add(OrderItem orderItem)
        {
            bool isRepeat = false;
            foreach (OrderItem o in orderItems)
            {
                if (orderItem.Equals(o))
                {
                    isRepeat = true;
                    break;
                }
            }
            if (!isRepeat)
            {
                orderItems.Add(orderItem);
                PriceSum += orderItem.Number * orderItem.Price;
            }
        }
        public void getPriceSum()
        {
            int total = 0;
            foreach (OrderItem o in orderItems)
            {
                total += o.Number * o.Price;
            }
            this.PriceSum = total;
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID &&
                   Customer == order.Customer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderID, Customer);
        }

        public override string ToString()
        {
            string s = "";
            foreach (OrderItem o in orderItems)
            {
                s += o.ToString();
            }
            return "单号:" + OrderID + "\n客户名:" + Customer + "\n总价:" + PriceSum + "\n订单明细:" + s + "\n";
        }
    }
}