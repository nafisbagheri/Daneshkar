namespace OnlineShop.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }        
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Login(){}            
        public void Logout(){}
        public void ChangePassword(){}
    }
}
