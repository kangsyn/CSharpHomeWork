  class OrderService
    {
        public List<Order> Orders { set; get; }

        public void AddOrder(Order order)
        {
            bool flag = false;
            foreach (Order _order in Orders)
            {
                flag = _order.Equals(order);
                if (flag)
                    break;
            }
            if (flag == false)
            {
                Orders.Add(order);
            }
        }
        public void delete(Order o)
        {
            orders.Remove(o);
        }        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

        public void RemoveAllOrders()
        {
            Orders.Clear();
        } public void sort()
        {
            orders.Sort((Order o1, Order o2) => o1.OrderID.CompareTo(o2.OrderID));
        }

        public void show()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void seekOrderID(int a)
        {
            var query = from o in orders
                        where o.OrderID == a
                        orderby o.PriceSum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void seekCustomer(string a)
        {
            var query = from o in orders
                        where o.Customer == a
                        orderby o.PriceSum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void seekCommodity(string a)
        {
            foreach (Order o in orders)
            {
                foreach (OrderItem d in o.orderItems)
                {
                    if (d.Commodity == a)
                    {
                        Console.WriteLine(o.ToString());
                        break;
                    }
                }
            }
        }
    }
