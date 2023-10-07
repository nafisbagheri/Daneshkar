namespace OnlineShop.Model
{
    public class Order
    {
        public ShoppingCart ShoppingCart { get; set; }
        public string totalPrice { get; set; }
        public string totalDiscount { get; set; }
        public string finalAmount { get; set; }
        public int Status { get; set; }

        public string  TotalPrice(){ return "0"; }
        public string  TotalDiscount(){ return "0"; }
        public string  FinalAmount(){ return "0"; }
    }
}
