 class OrderItem
    {
        internal Products Commodity { get; set; }
        public int ProductsNum { get; set; }
        public double Price { get; set; }

        public OrderItem(Products brand, int productsNum, double price)
        {
            Commodity= commodity;
            ProductsNum = productsNum;
            Price = price;
        }

        public override string ToString()
        {
            return Brand + " " + ProductsNum + " " + Price;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   Commodity == item.Commodity &&
                   ProductsNum == item.ProductsNum &&
                   Price == item.Price;
        }
          public override string ToString()
        {
            return "\n 商品名：" + Commodity + " 数目：" + Price + " 单价：" +  ProductsNum;
        }
    }