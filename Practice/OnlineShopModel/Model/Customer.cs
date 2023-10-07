namespace OnlineShop.Model
{
    public class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public void Register(){}
        public void EditProfile(){}
        public void AddAddress(Address Address){}
        public void EditAddress(){}
        public void RemoveAddress(){}
        public List<Product> Search(Product Product){return null;}
        public ShoppingCart DisplayShoppingCart() { return null; }
        public void AddProductTOShoppingCart(Product Product, int Count){}
        public void PaymentBill(){}
    }
}
