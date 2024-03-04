namespace OnlineShopWebApp.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Cost
        {
            get
            {
                return Quantity * Product.Cost;
            }
        }
    }
}
