namespace OnlineShopWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += Id.ToString() + "\n";
            result += Name.ToString() + "\n";
            result += Cost.ToString();
            return result;
        }

        public string ToString2()
        {
            string result = string.Empty;
            result += Id.ToString() + "\n";
            result += Name.ToString() + "\n";
            result += Cost.ToString() + "\n";
            result += Description.ToString();
            return result;
        }
    }
}
