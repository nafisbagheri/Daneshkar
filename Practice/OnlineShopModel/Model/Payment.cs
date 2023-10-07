namespace OnlineShop.Model
{
    public class Payment
    {
        public int PaymentType { get; set; }

        public void OnlinePayment(string ShopAccountNumner, decimal Amount, Account CustomerAccount){}
        public void DisplayeTrackingCode(){}
    } 
}
