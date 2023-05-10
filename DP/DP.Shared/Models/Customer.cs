namespace DP.Shared.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerType CustomerType { get; set; }
    }

    public class Order
    {
        public string OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double SubTotal
        {
            get { return Products.Sum(p => p.Price); }
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public enum CustomerType
    {
        REGULAR, PREMIUM
    }
}
