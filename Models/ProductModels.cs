namespace ElasticCollection.Models
{
    public class ProductModels
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public int Quantity { get; set; }
        public long OrderCount { get; set; }
        public string Category { get; set; }

        public ProductModels(string iD, string name, decimal price, int quantity, long orderCount, string category)
        {
            ID = iD;
            Name = name;
            Price = price;
            Quantity = quantity;
            OrderCount = orderCount;
            Category = category;
        }
    }
}
