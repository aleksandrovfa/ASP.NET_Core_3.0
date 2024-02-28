namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int constantCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public string Link { get; }

        public Product(string name, decimal cost, string description, string link)
        {
            Id = constantCounter;
            Name = name;
            Cost = cost;
            Description = description;
            Link = link;
            constantCounter++;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
