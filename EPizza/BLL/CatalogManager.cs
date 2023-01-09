namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{

   public List<PizzaProduct> GetAllProducts()
   {
    List<PizzaProduct> allProducts = new List<PizzaProduct>();
    allProducts=DBManager.GetAllProducts();
    return allProducts;
   }
}
