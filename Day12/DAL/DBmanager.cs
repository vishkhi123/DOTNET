namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBmanager
{
  public static List<Product> GetAllProduct(){
    List<Product> allproduct=new List<Product>();
        //step 1
    string conString=@"server=localhost;
                        port=3306;
                        user=root;
                        password=vishal9767;
                        database=prodb";
    //step 2
    MySqlConnection con=new MySqlConnection();
    //step 3 assigning string to con
    con.ConnectionString=conString;

    try{
        con.Open();
        string query="select * from product";
        MySqlCommand cmd=new MySqlCommand();
        //giving connection to command
        cmd.Connection=con;
        //passing query to Command Text
        cmd.CommandText=query;
        MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read())
        {
            int id=int.Parse(reader["Id"].ToString());
            string name=reader["Name"].ToString();
            string description=reader["Description"].ToString();
            string image=reader["Image"].ToString();
            double price=double.Parse(reader["Price"].ToString());


            Product prod=new Product(id,name,description,price,image);
            allproduct.Add(prod);

        }


    }
    catch(Exception e){
        Console.WriteLine(e);

    }
    finally{
        con.Close();
    }




  return allproduct;
  }

  public static void InsertProduct(Product product)
  {
    string conString=@"server=localhost;port=3306;user=root;password=vishal9767;database=prodb";
    //step 2
    MySqlConnection con=new MySqlConnection();
    //step 3 assigning string to con
    con.ConnectionString=conString;

    try{
        con.Open();
        string query="INSERT INTO PRODUCT VALUES("+product.Id+",'"+product.Name+"','"+product.Description+"','"+product.Image+"','"+product.Price+"');";
        MySqlCommand cmd=new MySqlCommand();
        //giving connection to command
        cmd.Connection=con;
        //passing query to Command Text
        cmd.CommandText=query;
        cmd.ExecuteNonQuery();
    }
    catch(Exception e){
        Console.WriteLine(e);

    }
    finally{
        con.Close();
    }

  }
}
