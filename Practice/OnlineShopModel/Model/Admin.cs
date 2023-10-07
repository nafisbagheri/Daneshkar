namespace OnlineShop.Model
{
    public class Admin : Person
    {
        public void AddProduct(Product Product){}
        public void EditProduct(int ProductId){}
        public void RemoveProduct(int ProductId){}      
        public void AddCategory(Category Category) { }
        public void EditCategory(int CategoryId) { }
        public void RemoveCategory(int CategoryId) { }
        public List<Product> GeListProducts() { return null; }
        public List<Category> GeListCategories() { return null; }
    }
}
