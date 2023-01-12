namespace DAL;
using BOL;
using System.Collections.Generic;
public class DBmanager
{

    public static List<Product> GetAllProduct()
    {
        List<Product> allProductList = new List<Product>();
        allProductList.Add(new Product(100, "piston"));
        allProductList.Add(new Product(200, "Connecting Rod"));
        allProductList.Add(new Product(300, "Cylinder"));
        allProductList.Add(new Product(500, "Piston ring"));
        allProductList.Add(new Product(400, "Crankshaft"));
        allProductList.Add(new Product(700, "Flywheel"));
        allProductList.Add(new Product(600, "CamShaft"));
        return allProductList;
    }


}
