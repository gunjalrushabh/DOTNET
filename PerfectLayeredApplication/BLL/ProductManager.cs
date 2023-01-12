namespace BLL;
using BOL;
using DAL;
public class ProductManager
{
public static List<Product> GetAllProducts(){
    List<Product> allproducts = new List<Product>();
   allproducts= DBmanager.GetAllProduct();
   return allproducts;
}
}
