namespace DAL;
using BOL;
public class DBManager
{
  public static List<PizzaProduct> GetAllProducts()
  {
    List<PizzaProduct> allProducts=new List<PizzaProduct>();
    allProducts.Add(new PizzaProduct(1,"Margherita","very tasty",500));
    allProducts.Add(new PizzaProduct(2,"Marinara","sweet",600));
    allProducts.Add(new PizzaProduct(3,"Quattro Stagioni","Cool", 700));
    allProducts.Add(new PizzaProduct(4,"Quattro Formaggi","Hot", 800));
    allProducts.Add(new PizzaProduct(5,"Carbonara","Awesome", 900));
    return allProducts;
    
  }
  


}
