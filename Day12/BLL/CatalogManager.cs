namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{
    public static List<Product> GetallProducts()
    {
        List<Product> allproduct=DBmanager.GetAllProduct();
        
        return allproduct;
    }

    public static void InsertProduct(Product product)
    { DBmanager.InsertProduct(product);

    }

}
