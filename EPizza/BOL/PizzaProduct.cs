namespace BOL;
public class PizzaProduct
{
   private int id;

   private string? title;
    private string? description;

    private int price;


//--------------Business POCO Object created----------------------


    public PizzaProduct(int id, string title)
    {
        this.id = id;
        this.title = title;
       
    }

    public PizzaProduct(int id, string title, string description, int price)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.price = price;
    }
    public int Price 
    {
        get { return price; }
        set { price = value; }
    }

    public string? Description
    {
        get { return description; }
        set { description = value; }
    }



    public string? Title
    {
        get { return title; }
        set { title = value; }
    }



    public int Id
    {
        get { return id; }
        set { id = value; }
    }
 
}
